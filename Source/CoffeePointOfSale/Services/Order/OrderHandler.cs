using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.Order {
    public class OrderHandler {
        private Order currentOrder;
        private Form orderScreenForm;

        public void SetCurrentOrder(Order currentOrder) {
            this.currentOrder = currentOrder;
        }

        public void SetOrderScreenForm(Form orderScreenForm) {
            this.orderScreenForm = orderScreenForm;
        }

        public void GoToPayment() {
            //share data with and switch to payment screen
        }

        public void AddDrinkToOrder() {
            CurrentDrink.CurrentDrink newDrink = new CurrentDrink.CurrentDrink();
            newDrink.Name = GetDrink();
            newDrink.Customizations = GetCustomizations();
            newDrink.Total = CalculateTotal();
        }

        private string GetDrink() {
            string name = "";

            //get drink name from screen elements 
            
            return name;
        }

        private string GetCustomizations() {
            string customizations = "";

            //get customizations from screen and concantinate into one string

            return customizations;
        }

        private decimal CalculateTotal() {
            decimal total = new decimal(0.00);
            decimal subtotal = CalculateSubtotal();
            decimal tax = CalculateTax();
            total = subtotal + tax;
            return total;
        }

        private decimal CalculateSubtotal() {
            decimal subtotal = new decimal(0.00);

            //get prices from drink menu and add them together

            return subtotal;
        }

        private decimal CalculateTax() {
            decimal tax = new decimal(0.00);
            decimal taxRate = new decimal(0.00); //get tax rate from config 
            decimal subtotal = CalculateSubtotal();
            tax = taxRate * subtotal;
            return tax;
        }

        private void DisplayTotals() {
            decimal total = CalculateTotal();
            decimal subtotal = CalculateSubtotal();
            decimal tax = CalculateTax();

            //display on form element
        }

        private void DisplayDrinks() {
            //display Drinks on form elements
        }

        private void DisplayCustomerName() {
            //display Customer name on Form element
        }

        public void CancelOrder() {
            // go back to FormMain
        }

        public void CreateOrder() {
            currentOrder = new Order();
        }
    }
}
