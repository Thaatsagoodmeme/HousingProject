using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingProject
{
    class Suggestion
    {
        public List<string> suggestList = new List<string>();

        string text = "";
        int index;
        public void AddSuggest(string text)
        {
            suggestList.Add(text);
        }

        public void RemoveSuggest(int index)
        {
            suggestList.RemoveAt(index);
        }
        public void Output(Comp_Rule_Agree_Sugges form)
        {
            form.suggestLstBx.Items.Clear();
            foreach (var item in suggestList)
            {
                form.suggestLstBx.Items.Add(item);
            }
        }
        public string checkIfValidInputDate(Comp_Rule_Agree_Sugges form)
        {
            try
            {
                text = form.suggestTxtBx.Text;
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
