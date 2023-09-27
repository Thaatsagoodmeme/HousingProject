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
    public partial class Comp_Rule_Agree_Sugges : Form
    {
        public Comp_Rule_Agree_Sugges()
        {
            InitializeComponent();
        }
        Complaiment comp = new Complaiment();
        Agreements agree = new Agreements();
        Rules rules = new Rules();
        Suggestion suggest = new Suggestion();
        string text = "";
        private void exitBt_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void backBt_Click(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main();
            m.Show();
        }
        private void addCompBt_Click(object sender, EventArgs e)
        {
            text = comp.checkIfValidInputDate(this);
            if (text != null)
            {
                comp.AddComplaiment(text);
                comp.Output(this);
            }
            else { }
        }
        private void removeCompBt_Click(object sender, EventArgs e)
        {
            if (this.compLstBx.Items.Count > 0)
            {
                comp.RemoveComplaiment(this.compLstBx.SelectedIndex);
                comp.Output(this);
            }
            else
            {
                MessageBox.Show("The message box is empty!");
            }
        }
        private void addAgreeBt_Click(object sender, EventArgs e)
        {
            text = agree.checkIfValidInputDate(this);
            if (text != null)
            {
                agree.AddAgreement(text);
                agree.Output(this);
            }
            else { }
        }
        private void removeAgreeBt_Click(object sender, EventArgs e)
        {
            if (this.agreeLstBx.Items.Count > 0)
            {
                agree.RemoveAgreement(this.agreeLstBx.SelectedIndex);
                agree.Output(this);
            }
            else
            {
                MessageBox.Show("The message box is empty!");
            }
        }
        private void addRuleBt_Click(object sender, EventArgs e)
        {
            text = rules.checkIfValidInputDate(this);
            if (text != null)
            {
                rules.AddRule(text);
                rules.Output(this);
            }
            else { }
        }
        private void removeRuleBt_Click(object sender, EventArgs e)
        {
            if (this.ruleLstBx.Items.Count > 0)
            {
                rules.RemoveRule(this.ruleLstBx.SelectedIndex);
                rules.Output(this);
            }
            else
            {
                MessageBox.Show("The message box is empty!");
            }
        }

        private void addSuggestBt_Click(object sender, EventArgs e)
        {
            text = suggest.checkIfValidInputDate(this);
            if (text != null)
            {
                suggest.AddSuggest(text);
                suggest.Output(this);
            }
            else { }
        }

        private void removeSuggestBt_Click(object sender, EventArgs e)
        {
            if (this.suggestLstBx.Items.Count > 0)
            {
                suggest.RemoveSuggest(this.suggestLstBx.SelectedIndex);
                suggest.Output(this);
            }
            else
            {
                MessageBox.Show("The message box is empty!");
            }
        }
    }
}
