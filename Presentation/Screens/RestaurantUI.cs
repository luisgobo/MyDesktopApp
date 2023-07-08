using BusinessLogic;
using Entities;
using System;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using Presentation.Screens;

namespace Presentation.Presentation
{
    public partial class RestaurantUI : Form
    {
        RestauranteLN rest;
        PlatoLN platoLn = new PlatoLN();
        List<Plato> platosSeleccionados = new List<Plato>();

        public RestaurantUI()
        {
            InitializeComponent();

            FillStateOptions();
            rest = new RestauranteLN();
            InitializeDataGridView();
            LoadData();
        }

        void InitializeDataGridView()
        {

            dgvRestaurantes.MultiSelect = true;
            dgvRestaurantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRestaurantes.ReadOnly = true;
            dgvRestaurantes.AutoGenerateColumns = false;

            dgvRestaurantes.Columns.Add("ID", "ID");
            dgvRestaurantes.Columns["ID"].DataPropertyName = "ID";
            dgvRestaurantes.Columns["ID"].Width = 50;

            dgvRestaurantes.Columns.Add("Nombre", "Nombre");
            dgvRestaurantes.Columns["Nombre"].DataPropertyName = "Nombre";
            dgvRestaurantes.Columns["Nombre"].Width = 120;

            dgvRestaurantes.Columns.Add("Direccion", "Direccion");
            dgvRestaurantes.Columns["Direccion"].DataPropertyName = "Direccion";
            dgvRestaurantes.Columns["Direccion"].Width = 120;

            dgvRestaurantes.Columns.Add("Estado", "Estado");
            dgvRestaurantes.Columns["Estado"].DataPropertyName = "Estado";
            dgvRestaurantes.Columns["Estado"].Width = 60;

            LoadData();

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
                Restaurant restaurant = new Restaurant(0, txtDescripcion.Text, "Anywhere" ,(bool)cbxActivo.SelectedValue);
                ValidationContext context = new ValidationContext(restaurant, null, null);

                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(restaurant, context, errors, true)) {
                    
                    foreach (ValidationResult result in errors) { 
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
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
                    //bool isActive = Convert.ToBoolean(e.Value);
                    if (e.Value != null)
                        e.Value = Convert.ToBoolean(e.Value) ? "Activo" : "Inactivo";
                }
            }
            catch (Exception ex)
            {
                e.Value = "Unknown";
            }
        }

        private void btnSelectedRows_Click(object sender, EventArgs e)
        {
            using (PlatosDialog platosDialog = new PlatosDialog())
            {
                DialogResult result = platosDialog.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    var listaIdsPlatosSeleccionados = platosDialog.idPlatosSeleccionados;
                    //Consultar Logica de negocios -> AccesoDatos mi lista de Ids Seleccionadas contra la lista existente, que retorne la lista de platos 
                    platosSeleccionados = platoLn.ListarPlatosSeleccionados(listaIdsPlatosSeleccionados);
                }
            }

        }
        
    }
}