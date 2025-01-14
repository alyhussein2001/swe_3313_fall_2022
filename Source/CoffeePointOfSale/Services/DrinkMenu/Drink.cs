﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu {
    public class Drink {
        private string name;
        private string baseDescription;
        private string image;
        private decimal basePrice;
        private List<Customization> customizations;

        public string Name { get; set; }
        public string BaseDescription { get; set; }
        public string Image { get; set; }
        public decimal BasePrice { get; set; }
        public List<Customization> Customizations { get; set; }
    }
}
