using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingProject
{
    class Rules
    {
        public List<string> ruleList = new List<string>();

        string text = "";
        int index;
        public void AddRule(string text)
        {
            ruleList.Add(text);
        }

        public void RemoveRule(int index)
        {
            ruleList.RemoveAt(index);
        }
        public void Output(Comp_Rule_Agree_Sugges form)
        {
            form.ruleLstBx.Items.Clear();
            foreach (var item in ruleList)
            {
                form.ruleLstBx.Items.Add(item);
            }
        }
        public string checkIfValidInputDate(Comp_Rule_Agree_Sugges form)
        {
            try
            {
                text = form.ruleTxtBx.Text;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Please first add text to the box below");
                text = null;
            }
            return text;
        }
    }
}
