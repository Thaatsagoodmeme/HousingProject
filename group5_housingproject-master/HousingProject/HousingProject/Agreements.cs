using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingProject
{
    class Agreements
    {
        public List<string> agreeList = new List<string>();

        string text = "";
        int index;
        public void AddAgreement(string text)
        {
            agreeList.Add(text);
        }

        public void RemoveAgreement(int index)
        {
            agreeList.RemoveAt(index);
        }
        public void Output(Comp_Rule_Agree_Sugges form)
        {
            form.agreeLstBx.Items.Clear();
            foreach (var item in agreeList)
            {
                form.agreeLstBx.Items.Add(item);
            }
        }
        public string checkIfValidInputDate(Comp_Rule_Agree_Sugges form)
        {
            try
            {
                text = form.agreeTxtBx.Text;
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
