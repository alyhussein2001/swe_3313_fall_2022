using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using Microsoft.Extensions.Logging;
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
    public partial class FormCustomerList : Base.FormNoCloseBase
    {
        
        private IAppSettings? _appSettings;
        private readonly ICustomerService _customerService;
        List<Button> buttons = new List<Button>();
        public FormCustomerList(IAppSettings appSettings, ICustomerService customerService)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            SetTitle("Customer List");
            DemonstrateGettingCustomerList();
        }


        private void bMM_CustList_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormAddCustomer>().Show();
        }

        private void DemonstrateGettingCustomerList()
        {
            int top = 3;
            int left = 900;
            var customerList = _customerService.Customers.List;
            for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
            {
                var customer = customerList[customerIdx];
                listBox1.Items.Add($"{customerIdx + 1}. {customer}{Environment.NewLine}");
                listBox1.Padding = new Padding(20, 0, 0, 20); 

                CreateButton(customer, top, left );
                top += 33;

            }
        }
        private void CreateButton(Customer customer, int top, int left)
        {

            Button button = new Button();
            button.Size = new Size(120, 27);
            button.Font = new Font("Century Gothic", 9);
            string hexColor = "#47525E";
            Color buttonColor = System.Drawing.ColorTranslator.FromHtml(hexColor); 

            button.Name = customer.Phone;

            button.Text = "Order Drink";
            button.ForeColor = Color.Transparent;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.BackColor = buttonColor;
            button.Left = left;
            button.Top = top;
            this.Controls.Add(button);
            button.Click += new EventHandler(orderDrinkClick);
            buttons.Add(button);


            listBox1.Controls.Add(button);
            button.Dock = DockStyle.None;
            button.BringToFront();

        }
        private void orderDrinkClick(object sender, EventArgs e)

        {
            Button btn = (Button)sender;
            var customerList = _customerService.Customers.List;
            foreach (Customer customer in customerList)
            {
                if (btn.Name == customer.Phone)
                {
                    FormMain.currentCustomer = customer;
                }
            }


            Close();
            FormFactory.Get<FormOrderDrink>().Show();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
