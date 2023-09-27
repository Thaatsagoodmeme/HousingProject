using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class GroceryListItem
    {
        private string description; 
        private double amount;   
        private UnitTypes unit;
        private double cost;

        public GroceryListItem() : this("Unknown", 1.0, UnitTypes.piece, 0.0)
        {

        }

        public GroceryListItem(string description, double amount, UnitTypes unit, double cost)
        {
            this.description = description;
            this.amount = amount;
            this.unit = unit;
            this.cost = cost;
        }

        public string Description {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        } 

        public double Amount {
            get
            {
                return amount;
            }
            set
            {
                if (value >= 0) 
                { 
                    amount = value;
                }
            }
        } 

        public double Cost {
            get 
            {
                return cost;
            }
            set 
            {
                if (value >= 0) 
                {
                    cost = value;
                }
            }
        }

        public UnitTypes Unit {
            get
            {
                return unit;
            }
            set
            {
                if (Enum.IsDefined(typeof(UnitTypes), value))
                {
                    unit = value;
                }
            }
        } 

        public override string ToString()
        {
            string textOut = string.Empty;
            textOut = $"{description} {amount} {unit} - {cost}";
            return textOut;
        } 

    } 
} 
