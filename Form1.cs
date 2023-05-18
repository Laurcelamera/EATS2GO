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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            productsPanel.Visible = false;
            SalesPanel.Visible = false;
        }

        private void btnSignin_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                MessageBox.Show("Welcome");
                mainPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Incorrect. Try again.");
            }
        }
        public void ClearAll()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            productsPanel.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            productsPanel.Visible = false;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            SalesPanel.Visible = false;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SalesPanel.Visible = true;
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            productsPanel.Visible = false;
            SalesPanel.Visible = false;
            ClearAll();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
