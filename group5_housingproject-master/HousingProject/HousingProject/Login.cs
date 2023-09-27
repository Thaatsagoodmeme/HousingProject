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
            passTxtBx.PasswordChar = '*';
        }
        Utility util = new Utility();

        private void LoginBt_Click(object sender, EventArgs e)
        {

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
            if(util.Login(name, pass))
            {
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Oo, it seems like something went wrong, please try again");
            }
            
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void registerBt_Click(object sender, EventArgs e)
        {
            string name = "";
            string pass = "";
            string house = "";
            string adminKey = "";
            try
            {
                name = this.nameRegTxtBx.Text;
                pass = this.passRegTxtBx.Text;
                house = this.houseCbx.SelectedItem.ToString();
                adminKey = this.admTxtBx.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill up the empty fields");
            }

            if (util.Register(name,pass,house,adminKey))
            {
                MessageBox.Show("Registration was succesfull");
            }
            else
            {
                MessageBox.Show("Oo, it seems like something went wrong, please try again");
            }
        }
    }
}
