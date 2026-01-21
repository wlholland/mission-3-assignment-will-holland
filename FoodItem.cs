using System;
using System.Collections.Generic;
using System.Text;

namespace mission_3_assignment
{

    public class FoodItem
    {
        // properties
        public string Name;
        public string Category;
        public int Quantity;
        public string ExpirationDate;

        // constructor for each food item and its properties
        public FoodItem(string name, string category, int quantity, string expirationDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpirationDate = expirationDate;
        }
        // A method to print details nicely for each food item
        public override string ToString()
        {
            return $"{Name} ({Category}) - Qty: {Quantity} - Exp: {ExpirationDate}";
        }
    }
}
