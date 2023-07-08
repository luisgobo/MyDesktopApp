using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Screens
{
    public partial class PlatosDialog : Form
    {
        private PlatoLN platoLn = new PlatoLN();
        private readonly Plato[] platos = new Plato[5];
        public List<int> idPlatosSeleccionados = new List<int>();

        public PlatosDialog()
        {
            InitializeComponent();            
            InitializeDataGridView();

        }

        void InitializeDataGridView()
        {

            //Seleccionar multiples celdas
            dgvPlatos.MultiSelect = true;
            dgvPlatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //El datagridviewView es de solo lectura
            dgvPlatos.ReadOnly = true;
            dgvPlatos.AutoGenerateColumns = false;


            //Configurar las columnas
            dgvPlatos.Columns.Add("ID", "ID");
            dgvPlatos.Columns["ID"].DataPropertyName = "ID";
            dgvPlatos.Columns["ID"].Width = 50;

            dgvPlatos.Columns.Add("Nombre", "Nombre");
            dgvPlatos.Columns["Nombre"].DataPropertyName = "Nombre";
            dgvPlatos.Columns["Nombre"].Width = 120;

            dgvPlatos.Columns.Add("Precio", "Precio");
            dgvPlatos.Columns["Precio"].DataPropertyName = "Precio";
            dgvPlatos.Columns["Precio"].Width = 120;            

            LoadData();

        }

        void LoadData()
        {

            dgvPlatos.DataSource = platoLn.ListarPlatos();
            dgvPlatos.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow[] selectedRows = dgvPlatos.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(row => !row.IsNewRow)
            .ToArray();

            foreach (var row in selectedRows)
                idPlatosSeleccionados.Add(int.Parse(row.Cells[0].Value.ToString()));

            string msg = "Desea Volver?";
            var pregunta = MessageBox.Show(msg, "Guardar Platos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (pregunta == DialogResult.Yes)
            {                
                this.Close();
            }
        }
    }
}
