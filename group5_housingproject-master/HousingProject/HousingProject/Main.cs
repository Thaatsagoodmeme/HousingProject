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
        private void scheduleBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shopping shopping = new Shopping();
            shopping.Show();
            /*Schedule schedule = new Schedule();
            schedule.Show();*/
        }
        private void exitBt_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void compBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comp_Rule_Agree_Sugges comp = new Comp_Rule_Agree_Sugges();
            comp.Show();
        }

        private void callendarBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendar_Form cal = new Calendar_Form(); 
            cal.Show();

        }

        private void contactBt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sierra.infora.hu/studenthouse/forum/indexT.php");
        }
    }
}
