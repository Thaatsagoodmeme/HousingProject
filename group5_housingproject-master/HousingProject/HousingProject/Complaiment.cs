using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingProject
{
    class Complaiment
    {
        public List<string> compList = new List<string>();

        string text = "";
        int index;
        public void AddComplaiment(string text)
        {
            compList.Add(text);
        }

        public void RemoveComplaiment(int index)
        {
            compList.RemoveAt(index);
        }
        public void Output(Comp_Rule_Agree_Sugges form)
        {
            form.compLstBx.Items.Clear();
            foreach (var item in compList)
            {
                form.compLstBx.Items.Add(item);
            }
        }
        public string checkIfValidInputDate(Comp_Rule_Agree_Sugges form)
        {
            try
            {
                text = form.comTxtBx.Text;
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
