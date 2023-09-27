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

namespace ShoppingList
{
    public partial class Shopping : Form
    {

        GroceryListEdit itemManager = new GroceryListEdit();
        int tab_shift = 0;

        public Shopping()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addSomeTestingStuff()
        {
            this.itemManager.Add_Test("Eggs", 6, UnitTypes.piece, 4.50);
            this.itemManager.Add_Test("Bread", 2, UnitTypes.piece, 1.50);
            this.itemManager.Add_Test("Flour", 750, UnitTypes.g, 5.0);
            this.itemManager.Add_Test("Milk", 3, UnitTypes.lit, 7.50);
            this.itemManager.Add_Test("Chicken", 700, UnitTypes.g, 8.0);
            this.itemManager.Add_Test("Cereal", 1, UnitTypes.kg, 12.50);
            this.itemManager.Add_Test("Nutella", 800, UnitTypes.g, 10.0);
            this.itemManager.Add_Test("Salt", 200, UnitTypes.g, 1.50);
            this.itemManager.Add_Test("Olive Oil", 1, UnitTypes.lit, 6.0);
            this.itemManager.Add_Test("Vanilla Extract", 100, UnitTypes.ml, 7.25);
            this.itemManager.Add_Test("Tabasco", 500, UnitTypes.ml, 3.25);
        }

        private void InitializeGUI()
        {
            cmbUnits.Items.AddRange(Enum.GetNames(typeof (UnitTypes)));
            cmbUnits.SelectedIndex = (int)UnitTypes.piece;
        }

        public void UpdateShoppingList()
        {
            string[] list = itemManager.GetItemsToString();
            lstItems.Items.Clear();

            if (list == null)
                return;

            for (int i = 0; i < list.Length; i++)
            {
                lstItems.Items.Add(list[i]);
            }
        }

        private void Message(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private double ReadAmount(out bool success)
        {
            double amount;
            success = false;

            if (!double.TryParse(txtAmount.Text, out amount))
            {
                Message("Error: Wrong Amount");
            }
            else
            {
                success = true;
            }

            return amount;
        }

        private UnitTypes ReadUnit(out bool success)
        {
            UnitTypes unit = UnitTypes.piece;
            success = false;

            if (!Enum.IsDefined(typeof(UnitTypes), cmbUnits.SelectedIndex))
            {
                Message("Error: Please select a valid unit type");
            }
            else
            {
                unit = (UnitTypes)cmbUnits.SelectedIndex;
                success = true;
            }

            return unit;
        }

        private string ReadDescription(out bool success)
        {
            string name = string.Empty;
            success = false;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                Message("Error: Please enter a descriptive name");
            }
            else
            {
                name = txtName.Text;
                success = true;
            }

            return name;
        }

        private double ReadCost(out bool success) 
        {
            double cost;
            success = false;

            if (!double.TryParse(textCost.Text, out cost))
            {
                Message("Error: Wrong Cost");
            }
            else
            {
                success = true;
            }

            return cost;
        }

        private GroceryListItem ReadInput(out bool success)
        {
            success = false;

            GroceryListItem item = new GroceryListItem();

            item.Description = ReadDescription(out success);

            if (!success)
                return null;

            item.Amount = ReadAmount(out success);

            if (!success)
                return null;

            item.Unit = ReadUnit(out success);

            item.Cost = ReadCost(out success);

            if (!success)
                return null;

            return item;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            bool success = false;

            GroceryListItem item = ReadInput(out success);

            if (success)
            {
                itemManager.Add(item);
                UpdateShoppingList();
            }
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            int selectedindex = lstItems.SelectedIndex;

            if (itemManager.Delete(selectedindex))
            {

                UpdateShoppingList();
            }
            else
            {
                Message("Error: Please first select item to delete");
            }
        }
        private void btnChange_Click_1(object sender, EventArgs e)
        {
            int selectedindex = lstItems.SelectedIndex;
            GroceryListItem item = null;
            bool success = false;

            item = ReadInput(out success);

            if (success && (item != null) && itemManager.Change(item, selectedindex))
            {
                UpdateShoppingList();
            }
            else
            {
                Message("Error: Please First Select Item to Change");
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedindex = lstItems.SelectedIndex;
            GroceryListItem item = null;

            item = itemManager.GetItem(selectedindex);

            if(item != null)
            {
                txtName.Text = item.Description;
                txtAmount.Text = item.Amount.ToString();
                textCost.Text = item.Cost.ToString();
                cmbUnits.SelectedIndex = (int) item.Unit;
            }
        }

        private void btnAddDefault_Click_1(object sender, EventArgs e)
        {
            addSomeTestingStuff();
            UpdateShoppingList();
        }

        //------------------------------------------------------------------------------------------------------------------------

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total_cost;
            total_cost = itemManager.GetListTotal();
            tbTotal.Text = Convert.ToString(total_cost);
        }

        private void btnSplitBill_Click(object sender, EventArgs e)
        {
            double payment_per_person;

            payment_per_person = Convert.ToDouble(tbTotal.Text) / Convert.ToInt32(tbSplit.Text);

            tbPperP.Text = Convert.ToString(payment_per_person);
        }

        //------------------------------------------------------------------------------------------------------------------------

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_shift == 0)
            {
                tabControlShoppingList.SelectedTab = Wallet;
                tab_shift = 1;
            }
            else
            if (tab_shift == 1)
            {
                tabControlShoppingList.SelectedTab = List;
                tab_shift = 0;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------

        private TheShoppingList.Wallet walletAccount;
        private List<TheShoppingList.Wallet> allAccounts = new List<TheShoppingList.Wallet>();

        public void UpdateWalletList()
        {
            lbWallets.Items.Clear();
            foreach (TheShoppingList.Wallet acc in allAccounts)
            {
                lbWallets.Items.Add(acc.GetInfo());
            }
        }

        private void btnAddw_Click(object sender, EventArgs e)
        {
            walletAccount = new TheShoppingList.Wallet();
            walletAccount.SetName(textWalletName.Text);
            walletAccount.SetWalletNr(textWalletNr.Text);
            walletAccount.SetBalance(Convert.ToDouble(textInitialBalance.Text));
            allAccounts.Add(walletAccount);
            lbWallets.Items.Add(walletAccount.GetInfo());

            UpdateWalletList();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double walletamount = Convert.ToDouble(textWalletAmount.Text);

            walletAccount = allAccounts[lbWallets.SelectedIndex];

            walletAccount.Withdraw(walletamount);

            UpdateWalletList();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double walletamount = Convert.ToDouble(textWalletAmount.Text);

            walletAccount = allAccounts[lbWallets.SelectedIndex];

            walletAccount.Deposit(walletamount);

            UpdateWalletList();
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            double walletamount = Convert.ToDouble(tbEqualCost.Text);

            for (int i = 0; i < lbWallets.Items.Count; i++)
            {
                walletAccount = allAccounts[i];
                walletAccount.Withdraw(walletamount);
                UpdateWalletList();
            }
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    } 
} 
