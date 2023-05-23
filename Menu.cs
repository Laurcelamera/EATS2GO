using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EATS2GO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnToForm1_Click(object sender, EventArgs e)
        {
            HOME form1 = new HOME();
            form1.Show();
            this.Hide();
            this.Close();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            DrinksPanel.Visible= false;
            FoodPanel.Visible= true;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            DrinksPanel.Visible = true;
            FoodPanel.Visible = false;
        }
    }
}
