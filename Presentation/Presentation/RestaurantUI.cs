using Presentation.BusinessLogic;
using Presentation.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Presentation
{
    public partial class RestaurantUI : Form
    {
        public RestaurantUI()
        {
            InitializeComponent();

            FillStateOptions();
            dgvRestaurantes.ReadOnly = true;
            
        }

        private void FillStateOptions()
        {
            bool[] restaurantState = { true, false };
            cbxActivo.DataSource = restaurantState;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
            
                RestaurantHandler rest = new RestaurantHandler();

                int restCounter = rest.ListRestaurants().Count();

                Restaurant restaurant = new Restaurant(txtNombre.Text,txtDescripcion.Text,(bool)cbxActivo.SelectedValue);
                rest.AddRestaurant(restaurant);

                dgvRestaurantes.DataSource = rest.ListRestaurants();
                dgvRestaurantes.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
