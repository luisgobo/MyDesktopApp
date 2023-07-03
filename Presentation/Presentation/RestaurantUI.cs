using Presentation.BusinessLogic;
using Presentation.Entities;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Presentation.Presentation
{
    public partial class RestaurantUI : Form
    {

        RestaurantHandler rest;
        DataGridViewTextBoxColumn textBoxColumn = null;

        public RestaurantUI()
        {
            InitializeComponent();

            FillStateOptions();
            rest = new RestaurantHandler();
            InitializeDataGridView();
            LoadData();

        }

        void InitializeDataGridView()
        {
            dgvRestaurantes.ReadOnly = true;
            dgvRestaurantes.AutoGenerateColumns = false;

            dgvRestaurantes.Columns.Add("ID", "ID");
            dgvRestaurantes.Columns.Add("Name", "Name");
            dgvRestaurantes.Columns.Add("Description", "Description");
            dgvRestaurantes.Columns.Add("Status", "Status");

            dgvRestaurantes.Columns["ID"].DataPropertyName = "ID";
            dgvRestaurantes.Columns["ID"].Width = 50;

            dgvRestaurantes.Columns["Name"].DataPropertyName = "Name";
            dgvRestaurantes.Columns["Name"].Width = 120;

            dgvRestaurantes.Columns["Description"].DataPropertyName = "Description";
            dgvRestaurantes.Columns["Description"].Width = 120;

            dgvRestaurantes.Columns["Status"].DataPropertyName = "Status";
            dgvRestaurantes.Columns["Status"].Width = 60;


            LoadData();

            //// Add columns to the DataGridView, binding them to the
            //// specified DataGridViewColumn properties.
            //AddReadOnlyColumn("HeaderText", "Id");
            //AddColumn("Name");
            //AddColumn("Description");
            //AddColumn("Enabled");

            //// Bind the DataGridView to its own Columns collection.
            //dgvRestaurantes.AutoGenerateColumns = false;
            ////dgvRestaurantes.DataSource = dgvRestaurantes.Columns;            
            //dgvRestaurantes.DataSource = rest.ListRestaurants();
            //dgvRestaurantes.Refresh();

            //// Configure the DataGridView so that users can manually change
            //// only the column widths, which are set to fill mode.
            //dgvRestaurantes.AllowUserToAddRows = false;
            //dgvRestaurantes.AllowUserToDeleteRows = false;
            //dgvRestaurantes.AllowUserToResizeRows = false;
            //dgvRestaurantes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            //dgvRestaurantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //dgvRestaurantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //// Configure the top left header cell as a reset button.
            //dgvRestaurantes.TopLeftHeaderCell.Value = "reset";
            //dgvRestaurantes.TopLeftHeaderCell.Style.ForeColor = System.Drawing.Color.Blue;

            //// Add handlers to DataGridView events.
            //dgvRestaurantes.CellClick += new DataGridViewCellEventHandler(dgvRestaurantes_CellClick);
            //dgvRestaurantes.ColumnWidthChanged += new DataGridViewColumnEventHandler(dgvRestaurantes_ColumnWidthChanged);
            //dgvRestaurantes.CurrentCellDirtyStateChanged += new EventHandler(dgvRestaurantes_CurrentCellDirtyStateChanged);
            //dgvRestaurantes.DataError += new DataGridViewDataErrorEventHandler(dgvRestaurantes_DataError);
            //dgvRestaurantes.CellEndEdit += new DataGridViewCellEventHandler(dgvRestaurantes_CellEndEdit);
            //dgvRestaurantes.CellValueChanged += new DataGridViewCellEventHandler(dgvRestaurantes_CellValueChanged);
        }

        void FillStateOptions()
        {
            bool[] restaurantState = { true, false };
            cbxActivo.DataSource = restaurantState;
        }
        void LoadData()
        {
            dgvRestaurantes.DataSource = rest.ListRestaurants();
            dgvRestaurantes.Refresh();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurant restaurant = new Restaurant(txtNombre.Text, txtDescripcion.Text, (bool)cbxActivo.SelectedValue);
                rest.AddRestaurant(restaurant);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
        }

        void dgvRestaurantes_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            //// Avoid recursion
            //if (e.Column == textBoxColumn) return;

            //DataGridView gridView = sender as DataGridView;
            //if (gridView == null) return;

            //if (e.Column is DataGridViewCheckBoxColumn)
            //{
            //    textBoxColumn = new DataGridViewTextBoxColumn();
            //    textBoxColumn.Name = e.Column.Name;
            //    textBoxColumn.HeaderText = e.Column.HeaderText;
            //    textBoxColumn.DataPropertyName = e.Column.DataPropertyName;

            //    gridView.Columns.Insert(e.Column.Index, textBoxColumn);
            //    gridView.Columns.Remove(e.Column);
            //}
        }

        void dgvRestaurantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn col = dgvRestaurantes.Columns[e.ColumnIndex];

            try
            {
                if (col.Name == "Status")
                {
                    bool isActive = Convert.ToBoolean(e.Value);
                    if (e.Value != null)
                        e.Value = isActive ? "Activo" : "Inactivo";
                }
            }
            catch (Exception ex)
            {
                e.Value = "Unknown";
            }
        }
    }
}