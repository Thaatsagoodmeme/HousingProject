using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class GroceryListEdit
    {
        public double total;
        private List<GroceryListItem> itemList;

        public GroceryListEdit()
        {
            itemList = new List<GroceryListItem>();

        }

        public int Count {

            get
            {
                return itemList.Count;
            }
        } 

        public GroceryListItem GetItem(int index)
        {
            return itemList[index];
        }

        public List<GroceryListItem> GetList()
        {
            return itemList;
        }

        public double GetListTotal()
        {
            total = 0;

            foreach (GroceryListItem groceryListItem in itemList)
            {
                total = groceryListItem.Cost + total;
            }

            return total;
        }

        private bool Check_Index(int index)
        {
            bool selected = false;

            if (index >= 0)
            {
                selected = true;
            }

            return selected;
        }

        public void Add_Test(string description, double amount, UnitTypes unit, double cost)
        {
            GroceryListItem groceryListItem;
            groceryListItem = new GroceryListItem(description, amount, unit, cost);
            itemList.Add(groceryListItem);
        }

        public bool Add(GroceryListItem itemIn)
        {
            bool add = false;

            if(itemIn != null)
            {
                itemList.Add(itemIn);
                add = true;
            }

            return add;
        } 

        public bool Change(GroceryListItem itemIn, int index)
        {
            bool ok = false;
            if(Check_Index(index))
            {
                itemList[index].Description = itemIn.Description;
                itemList[index].Amount = itemIn.Amount;
                itemList[index].Cost = itemIn.Cost;
                itemList[index].Unit = itemIn.Unit;
                ok = true;
            }

            return ok;
        } 
        public bool Delete(int index)
        {
            bool ok = false;

            if( Check_Index(index))
            {
                itemList.RemoveAt(index);
                ok = true;
            }

            return ok;
        } 
        public string[] GetItemsToString()
        {
            string[] stringInfoStrings = new string[itemList.Count];

            int i = 0;

            foreach (GroceryListItem item in itemList)
            {
                stringInfoStrings[i++] = item.ToString();
            }

            return stringInfoStrings;
        } 

    } 
} 
