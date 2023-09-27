using HousingProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingStudentProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void LoginBt_Click(object sender, EventArgs e)
        {
            Utility util = new Utility();
            util.DeafultUser("Test", "Apple");


            string name = "";
            string pass = "";
            try
            {
                name = this.nameTxtBx.Text;
                pass = this.passTxtBx.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill up the empty fields");
            }
            
            List<string> NameList = new List<string>();
            List<string> PassList = new List<string>();
            NameList = util.UserList.Select(x => x.Name).ToList();
            PassList = util.UserList.Select(x => x.Pass).ToList();
            if (NameList.Contains(name) && PassList.Contains(pass))
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void registerBt_Click(object sender, EventArgs e)
        {

        }
    }
}
