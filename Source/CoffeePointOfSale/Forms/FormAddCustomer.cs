using CoffeePointOfSale.Configuration;
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
        string firstName, lN, phoneNum;
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
            invalidDataError.Hide();
        }

        private void FirstName(object sender, EventArgs e)
        {
            firstName = textBox1.Text;
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            lN = lastName.Text;
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            if (firstName is null || lN is null || phoneNum is null)
            {
                error.Show();
            }
            else if(!FirstNameIsValid() || !LastNameIsValid() || !PhoneIsValid())
            {
                invalidDataError.Show();
            }
            else
            {
                invalidDataError.Hide();
                error.Hide();
                cust_data_error.Hide();
                var newCust = new Customer()
                {
                    FirstName = firstName,
                    LastName = lN,
                    Phone = phoneNum,
                    RewardPoints = 0,

                };
                if (_customerService.Customers[newCust.Phone] == null)
                {
                    _customerService.Customers.Add(newCust);
                    FormMain.currentCustomer= newCust;
                    _customerService.Write();
                    Close();
                    FormFactory.Get<FormOrderDrink>().Show();
                }
                else cust_data_error.Show();

            }

        }

        private bool FirstNameIsValid()
        {
            if (!firstName.All(Char.IsLetter))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool LastNameIsValid()
        {
            if (!lN.All(Char.IsLetter))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool PhoneIsValid()
        {
            int count = 1;
            if(!(phoneNum.Length == 12))
            {
                return false;
            }
            foreach(char charatcer in phoneNum)
            {
                if(count == 4 || count == 8)
                {
                    if (charatcer != '-')
                    {
                        return false;
                    }
                }
                else
                {
                    if (!char.IsDigit(charatcer))
                    {
                        return false;
                    }
                }
                count++;
            }
            return true;
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