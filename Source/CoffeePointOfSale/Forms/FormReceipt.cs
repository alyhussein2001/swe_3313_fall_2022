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
            SetTitle("Receipt");
            DisplayReceipt();
            _customerService.Write();
        }

        private void DisplayReceipt()
        {
            FormMain.currentOrder.TransactionDate = DateTime.Now;

            richTextBox1.Text = "";
            string display = "\n123 Kennesaw Road, Kennesaw, GA 30144\n\nCustomer Info:\n"
                + FormMain.currentCustomer.FirstName + " " + FormMain.currentCustomer.LastName + "\n";

            if(FormMain.currentOrder.PaymentMethod.Contains("card"))
            {
                display += "\nCard Number: **** **** **** " + FormMain.currentOrder.PaymentMethod.Remove(0, 16) + "\n";
                FormMain.currentOrder.PaymentMethod = FormMain.currentOrder.PaymentMethod.Remove(4, 16);
                if (!FormMain.currentCustomer.IsAnonymous)
                {
                    display += "\nPoints Earned: " + (int)FormMain.currentOrder.Total * 10 + "\n";
                    FormMain.currentCustomer.RewardPoints += (int)FormMain.currentOrder.Total * 10;
                    FormMain.currentCustomer.AddOrderToHistory(FormMain.currentOrder);
                }
            }
            else if(FormMain.currentOrder.PaymentMethod == "points")
            {
                int neededPoints = (int)FormMain.currentOrder.Total * 10;
                FormMain.currentCustomer.RewardPoints -= neededPoints;
                display += "\nPoints Spent: " + neededPoints + "\n";
                display += "Points Reamaining: " + FormMain.currentCustomer.RewardPoints + "\n";
                FormMain.currentCustomer.AddOrderToHistory(FormMain.currentOrder);
            }

            display += "Order:\n";

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
