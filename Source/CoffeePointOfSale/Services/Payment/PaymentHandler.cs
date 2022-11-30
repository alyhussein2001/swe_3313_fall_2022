using CoffeePointOfSale.Forms;
using CreditCardValidator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeePointOfSale.Services.Payment {
    public class PaymentHandler {
       private Order.Order currentOrder;
       private FormPayment formPayment;

        public PaymentHandler() {

        }

        public void GoToReceipt(bool withCard) {
            if (withCard) {

            }
            else {
                

            }
            //share data and go to receipt form
        }

        public void SetCurrentOrder(Order.Order currentOrder) {
            this.currentOrder = currentOrder;
        }

        public void SetPaymentScreenForm(FormPayment paymentScreenForm) {
            this.formPayment = paymentScreenForm;
        }

        private void DisplayCustomerName() {
            //display customer name on form element
        }

        private void DisplayTotal() {
            //display Total on form element
        }

        public string GetCardNumber(string cardNumber) {

            if (ValidateCardNumber(cardNumber)) {
                Debug.Write("Valid"); 
                return cardNumber;
            }
            else 
            {// print out exception and allow new input ?????
                throw new ArgumentException("Invalid Card Number");
            }
            
        }
        private bool ValidateCardNumber(string cardNumber) {
            CreditCardDetector detector = new CreditCardDetector(cardNumber);
          //  Debug.Write(cardNumber + "hello there :) :) :) :) :) ");
            return detector.IsValid();
    
        }

        public int GetRewardPoints() {
            if (CheckRewardPoints())
            {
                return GetTotalRewardPoints(); 
            }
            else
                throw new ArgumentException("Insufficient Points"); 

        }
                private bool CheckRewardPoints() 
        {
          //  Debug.Assert(currentOrder.Total >= 0);   
            int neededPoints = (int)currentOrder.Total * 10;
            return neededPoints <= GetTotalRewardPoints();

        } 
        private int GetTotalRewardPoints()
        {
            return (int) currentOrder.Customer.RewardPoints; 
        }
       
 



    }
}
