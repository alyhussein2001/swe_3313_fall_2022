﻿using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
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
    public partial class FormAddCustomer : Base.FormNoCloseBase
    {
        string firtname, lN, phoneNum;
        private IAppSettings _appSettings;
        private readonly ICustomerService _customerService;
        public FormAddCustomer(IAppSettings appSettings, ICustomerService customerService)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            error.Hide();
            cust_data_error.Hide();
        }

        private void FirstName(object sender, EventArgs e)
        {
            firtname = textBox1.Text;
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            lN = lastName.Text;
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            if (firtname is null || lN is null || phoneNum is null)
            {
                error.Show();
            }
            else
            {
                error.Hide();
                cust_data_error.Hide();
                var newCust = new Customer()
                {
                    FirstName = firtname,
                    LastName = lN,
                    Phone = phoneNum,
                    RewardPoints = 0,

                };
                if (_customerService.Customers[newCust.Phone] == null)
                {
                    _customerService.Customers.Add(newCust);
                    FormMain.currentCustomer= newCust;
                    Close();
                    FormFactory.Get<FormOrderDrink>().Show();
                }
                else cust_data_error.Show();
                    
            }
            
        }

        private void firstLabel_Click(object sender, EventArgs e)
        {

        }


        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            phoneNum = phoneNumber.Text;
        }

        private void addCust_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().Show(); 
        }
        
    }
}
