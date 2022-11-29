using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.Payment {
    public class PaymentHandler {
        private Order.Order currentOrder;
        private Form paymentScreenForm;

        public PaymentHandler() {

        }

        public void GoToReceipt(bool withCard) {
            if (withCard) {
                GetCardNumber();
            }
            else {
                //look at reward points
            }
            //share data and go to receipt form
        }

        public void SetCurrentOrder(Order.Order currentOrder) {
            this.currentOrder = currentOrder;
        }

        public void SetPaymentScreenForm(Form paymentScreenForm) {
            this.paymentScreenForm = paymentScreenForm;
        }

        public void CancelOrder() {
            //go back to FormMain
        }

        private void DisplayCustomerName() {
            //display customer name on form element
        }

        private void DisplayTotal() {
            //display Total on form element
        }

        private string GetCardNumber() {
            string cardNumber = "";

            //get card number from input element on form

            if (ValidateCardNumber(cardNumber)) {
                return cardNumber;
            }
            else 
            {
                throw new ArgumentException("Invalid Card Number");
            }
            
        }

        private bool ValidateCardNumber(string cardNumber) {
            bool valid = false;

            //validate card number using math

            return valid;
        }

        private int CalculateNeededRewardPoints() {
            int neededPoints = (int)currentOrder.Total * 10;
            return neededPoints;
        }

        private bool CheckRewardPoints() {
            int neededPoints = CalculateNeededRewardPoints();
            if (neededPoints <= currentOrder.Customer.RewardPoints) {
                return true;
            }
            else {
                return false;
            }
        }



    }
}
