using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.CurrentDrink;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormReceipt : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        private readonly ICustomerService _customerService;
        public FormReceipt(IAppSettings appSettings, ICustomerService customerService)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            DisplayReceipt();
        }

        private void DisplayReceipt()
        {
            richTextBox1.Text = "";
            string display = "123 Kennesaw Road, Kennesaw, GA 30144\nCustomer Info:\n" + FormMain.currentCustomer.FirstName + " " + FormMain.currentCustomer.LastName + "\nOrder:\n";

            //add points/card

            Drink drinkItem = new Drink();
            foreach (CurrentDrink currentDrink in FormMain.currentOrder.Drinks)
            {
                List<Customization> customs = new List<Customization>();
                drinkItem = GetDrinkFromMenu(currentDrink.Name);
                foreach (Customization custom in drinkItem.Customizations)
                {
                    if (currentDrink.Customizations.Contains(custom.Name))
                    {
                        customs.Add(custom);
                    }
                }

                display += "$" + GetDrinkFromMenu(currentDrink.Name).BasePrice + "     " + currentDrink.Name + "\n";

                foreach (Customization custom in customs)
                {
                    if (custom.Price >= 0)
                    {
                        display += "     $" + custom.Price + "     " + custom.Name + "\n";
                    }
                    else
                    {
                        display += "    -$" + custom.Price.ToString().Remove(0, 1) + "     " + custom.Name + "\n";
                    }

                }
            }

            display += "Subtotal: $" + FormMain.currentOrder.Subtotal.ToString() + "\n";



            display += "Tax: $" + FormMain.currentOrder.Tax.ToString("0.00") + "\n";



            display += "Total: $" + FormMain.currentOrder.Total.ToString("0.00");

            richTextBox1.Text = display;
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

        private void mainMenu_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }
    }
}
