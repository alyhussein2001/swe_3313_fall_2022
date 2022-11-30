using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.Order {
    public class Order {
        private List<CurrentDrink.CurrentDrink> drinks;
        private decimal tax;
        private decimal subtotal;
        private decimal total;
        private string paymentMethod;
        private Customer.Customer customer;

        public Order() {
            drinks = new List<CurrentDrink.CurrentDrink>();
            tax = new decimal(0.00);
            subtotal = new decimal(0.00);
            total = new decimal(0.00);
            paymentMethod = "";
        }

        public decimal Tax { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public CoffeePointOfSale.Services.Customer.Customer Customer { get; set; }
        public List<CurrentDrink.CurrentDrink> Drinks { get { return drinks; } }

        public void AddDrink(CurrentDrink.CurrentDrink newDrink) {
            drinks.Add(newDrink);
        }
    }
}
