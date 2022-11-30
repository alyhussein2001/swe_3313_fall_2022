using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.Order;
using CoffeePointOfSale.Services.Payment;
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
using System.Xml.Schema;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPayment : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        private readonly ICustomerService _customerService;
        private PaymentHandler paymentHandler = new PaymentHandler(); 


        public FormPayment(IAppSettings appSettings, ICustomerService customerService)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
        }

            

        private void FormPayment_Load(object sender, EventArgs e)
        {
            if (FormMain.currentCustomer.Phone == "anonymous" || !paymentHandler.CheckRewardPoints())
            {
                payPoints.Enabled = false;
            }
            else label5.Text = $"{FormMain.currentCustomer.RewardPoints}";
            label4.Text = FormMain.currentCustomer.FirstName + " " + FormMain.currentCustomer.LastName;

            label6.Text = "$" + FormMain.currentOrder.Total.ToString("0.00");
            invalidCard.Hide();


            // Debug.WriteLine("hello");
            // Debug.WriteLine(_customerService.Customers["404-444-5555"].ToString());

        }

        private void Cancel_Payment_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().Show();
        }
     

        private void payPoints_Click(object sender, EventArgs e)
        {
            paymentHandler.GetRewardPoints();
            paymentHandler.GoToReceipt(false, "0");
            this.Close();
            FormFactory.Get<FormReceipt>().Show();
        }

        private void payCard_Click(object sender, EventArgs e)
        {
            //  Debug.Write(CCnumber.Text); 

   
            paymentHandler.GetCardNumber(CCnumber.Text);
            if (!paymentHandler.ValidateCardNumber(CCnumber.Text))
                invalidCard.Show();
            paymentHandler.GoToReceipt(true, CCnumber.Text);

            invalidCard.Hide(); 

            paymentHandler.GetCardNumber(CCnumber.Text);
            paymentHandler.GoToReceipt(true, CCnumber.Text);
            this.Close();
            FormFactory.Get<FormReceipt>().Show();

        }

        private void CCnumber_TextInput (object sender, EventArgs e)
        {
           // Debug.Write(CCnumber.Text); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void invalidCard_Click(object sender, EventArgs e)
        {

        }
    }
}
