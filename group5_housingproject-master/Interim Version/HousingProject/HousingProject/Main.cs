using HousingStudentProject;
using ShoppingList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void shoppingBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shopping shopping = new Shopping();
            shopping.Show();
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
