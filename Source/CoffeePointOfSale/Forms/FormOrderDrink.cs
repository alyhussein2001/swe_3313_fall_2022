using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.CurrentDrink;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrderDrink : Base.FormNoCloseBase 
    {
        private IAppSettings? _appSettings;
        private ICustomerService? _customerService;
        private IDrinkMenuService _drinkMenuService;
        
        public FormOrderDrink(IAppSettings? appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService)
        {
            InitializeComponent();
            _appSettings= appSettings;
            _customerService = customerService;
            _drinkMenuService= drinkMenuService;
        }
        
        private void FormOrderDrink_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            FormMain.currentOrder = new Order();
            FormMain.currentOrder.Customer = FormMain.currentCustomer;

            custName.Text = FormMain.currentCustomer.FirstName + " " + FormMain.currentCustomer.LastName;

            List<Drink> drinkMenu = FormMain.drinkMenu;
            for (int drinkIdx = 0; drinkIdx < drinkMenu.Count; drinkIdx++) {
                Drink drink = drinkMenu[drinkIdx];
                listBox1.Items.Add(drink.Name);
            }
        }

        private void orderDrink_Close_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        private void callPayment_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormPayment>().Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            listBox2.Items.Clear();
            string selected = listBox1.SelectedItem.ToString();
            List<Drink> drinkMenu = FormMain.drinkMenu;
            foreach (Drink drink in drinkMenu) {
                if (drink.Name == selected) {
                    foreach (Customization customization in drink.Customizations) {
                        listBox2.Items.Add(customization.Name);
                    }
                }
            }
        }

        private void addDrink_Click(object sender, EventArgs e) {
            CurrentDrink newDrink = new CurrentDrink();
            Drink drinkItem = GetDrinkFromMenu(listBox1.SelectedItem.ToString());
            Debug.WriteLine(drinkItem.Name);
            newDrink.Name = drinkItem.Name;

            string customs = "";
            foreach(string custom in listBox2.SelectedItems) {
                if (customs == "") {
                    customs += custom;
                }
                else {
                    customs += "," + custom;
                }
            }

            newDrink.Customizations = customs;

            decimal total = drinkItem.BasePrice;

            foreach (Customization custom in drinkItem.Customizations) {
                foreach (string CustomName in listBox2.SelectedItems) {
                    if(custom.Name == CustomName) {
                        total += custom.Price;
                    }
                }
            }
            newDrink.Total = total;

            Debug.WriteLine(newDrink.Name + "   " + newDrink.Customizations + "   " + newDrink.Total);

            FormMain.currentOrder.AddDrink(newDrink);
            DisplayOrder();
        }

        private Drink GetDrinkFromMenu(string drinkName) {
            foreach (Drink drink in FormMain.drinkMenu) {
                if (drink.Name == drinkName) {
                    return drink;
                }
            }

            return null;
        }

        private void DisplayOrder() {
            Drink drinkItem = new Drink();
            List<Customization> customs = new List<Customization>();
            foreach (CurrentDrink currentDrink in FormMain.currentOrder.Drinks){
                Debug.WriteLine(currentDrink.Name);
                drinkItem = GetDrinkFromMenu(currentDrink.Name);
                foreach (Customization custom in drinkItem.Customizations) {
                    foreach (string CustomName in listBox2.SelectedItems) {
                        if (custom.Name == CustomName) {
                            customs.Add(custom);
                        }
                    }
                }


                label2.Text += "$" + currentDrink.Total + "     " + currentDrink.Name + "\n";

                foreach (Customization custom in customs) {
                    label2.Text += "     $" + custom.Price + "     " + custom.Name + "\n";
                }
            }
            
        }
    }
}
