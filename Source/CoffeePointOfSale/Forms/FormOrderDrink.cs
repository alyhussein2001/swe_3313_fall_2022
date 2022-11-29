using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //sets customer name on diplay
            custName.Text = FormMain.currentCustomer.FirstName + " " + FormMain.currentCustomer.LastName;

            listBox1.Items.Add("Latte");
            listBox1.Items.Add("Iced Latte");
            listBox1.Items.Add("Coffee");


            //IReadOnlyList<Drink> drinkMenu = _drinkMenuService.DrinkMenu.List;
            //for (int drinkIdx = 0; drinkIdx < drinkMenu.Count; drinkIdx++) {
            //    Drink drink = drinkMenu[drinkIdx];
            //    listBox1.Items.Add(drink.Name);
            //}
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
            //IReadOnlyList<Drink> drinkMenu = _drinkMenuService.DrinkMenu.List;
            List<Drink> drinkMenu = new List<Drink>();
            Drink drinkTemp = new Drink();
            drinkTemp.Name = "Coffee";
            //drinkTemp.Customizations = 
            foreach (Drink drink in drinkMenu) {
                if (drink.Name == selected) {
                    foreach (Customization customization in drink.Customizations) {
                        listBox2.Items.Add(customization.Name);
                    }
                }
            }
        }
    }
}
