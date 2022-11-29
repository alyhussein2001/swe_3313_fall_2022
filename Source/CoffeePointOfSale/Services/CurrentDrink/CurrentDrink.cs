using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.CurrentDrink {
    public class CurrentDrink {
        private string name;
        private string customizations;
        private decimal total;

        public CurrentDrink() {
            name = "";
            customizations = "";
            total = new decimal(0.00);
        }

        public string Name { get; set; }
        public string Customizations { get; set; }
        public decimal Total { get; set; }

    }
}
