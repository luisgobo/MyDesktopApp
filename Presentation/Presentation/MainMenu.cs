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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            RestaurantUI form = new RestaurantUI();
            form.Show();
        }
    }
}
