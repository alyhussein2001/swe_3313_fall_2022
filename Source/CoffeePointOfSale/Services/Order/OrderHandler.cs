using CoffeePointOfSale.Forms;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeePointOfSale.Services.CurrentDrink;
using System.Diagnostics;
using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Order {
    public class OrderHandler {

        public decimal CalculateTotal(Order currentOrder) {
            decimal total = 0;
            decimal subtotal = CalculateSubtotal(currentOrder);
            decimal tax = CalculateTax(currentOrder);
            total = subtotal + tax;
            return total;
        }

         public decimal CalculateSubtotal(Order currentOrder) {
            decimal subtotal = 0;
            
            Drink drinkItem = new Drink();
            foreach (CurrentDrink.CurrentDrink currentDrink in FormMain.currentOrder.Drinks)
            {
                drinkItem = GetDrinkFromMenu(currentDrink.Name);
                subtotal += drinkItem.BasePrice;
                foreach (Customization custom in drinkItem.Customizations)
                {
                    if (currentDrink.Customizations.Contains(custom.Name))
                    {
                        subtotal += custom.Price;
                    }
                }
            }
                return subtotal;
         }

         public decimal CalculateTax(Order currentOrder) {
            decimal tax = 0;
            decimal taxRate = GetTaxRate();
            decimal subtotal = CalculateSubtotal(currentOrder);
            tax = taxRate * subtotal;
            return tax;
         }

        private Drink GetDrinkFromMenu(string drinkName)
        {
            foreach (Drink drink in FormMain.drinkMenu)
            {
                if (drink.Name == drinkName)
                {
                    return drink;
                }
            }

            return null;
        }

        private decimal GetTaxRate()
        {
            AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText("appsettings.json"));
            return appSettings.Tax.Rate;
        }
    }
}
