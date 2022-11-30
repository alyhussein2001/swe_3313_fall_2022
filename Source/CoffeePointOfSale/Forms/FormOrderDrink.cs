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
            callPayment.Enabled = false;
            richTextBox1.Text = "";
            richTextBox1.Padding = new Padding(15, 15, 15, 15);
            FormMain.currentOrder = new Order();

            custName.Text = FormMain.currentCustomer.LastName + ", " + FormMain.currentCustomer.FirstName;

            List<Drink> drinkMenu = FormMain.drinkMenu;
            for (int drinkIdx = 0; drinkIdx < drinkMenu.Count; drinkIdx++) {
                Drink drink = drinkMenu[drinkIdx];
                listBox1.Items.Add(drink.Name);
                listBox1.Padding = new Padding(15, 15, 15, 15);

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
                        listBox2.Padding = new Padding(15, 15, 15, 15);

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
            SetAndDisplayTotals();
            callPayment.Enabled = true;
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
            richTextBox1.Text = "";
            Drink drinkItem = new Drink();
            foreach (CurrentDrink currentDrink in FormMain.currentOrder.Drinks){
                List<Customization> customs = new List<Customization>();
                Debug.WriteLine(currentDrink.Name);
                drinkItem = GetDrinkFromMenu(currentDrink.Name);
                foreach (Customization custom in drinkItem.Customizations) {
                    if (currentDrink.Customizations.Contains(custom.Name)) {
                        customs.Add(custom);
                    }
                }

                richTextBox1.Text += "$" + GetDrinkFromMenu(currentDrink.Name).BasePrice + "     " + currentDrink.Name + "\n";

                foreach (Customization custom in customs) {
                    if(custom.Price >= 0)
                    {
                        richTextBox1.Text += "     $" + custom.Price + "     " + custom.Name + "\n";
                    }
                    else
                    {
                        richTextBox1.Text += "    -$" + custom.Price.ToString().Remove(0,1) + "     " + custom.Name + "\n";
                    }
                    
                }
            }
        }

        private void SetAndDisplayTotals()
        {
            OrderHandler orderHandler = new OrderHandler();
            decimal subtotal = orderHandler.CalculateSubtotal(FormMain.currentOrder);
            label1.Text = "";
            label1.Text = "Subtotal: $" + subtotal;

            FormMain.currentOrder.Subtotal = subtotal;

            decimal tax = orderHandler.CalculateTax(FormMain.currentOrder);
            label2.Text = "";
            label2.Text = "Tax: $" + tax.ToString("0.00");

            FormMain.currentOrder.Tax = tax;

            decimal total = orderHandler.CalculateTotal(FormMain.currentOrder);
            label3.Text = "";
            label3.Text = "Total: $" + total.ToString("0.00");

            FormMain.currentOrder.Total = total;
        }

        private void horizontalLine_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void custName_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
