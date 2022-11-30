using CoffeePointOfSale.Forms;
using CoffeePointOfSale.Forms.Base;
using CreditCardValidator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeePointOfSale.Services.FormFactory;


namespace CoffeePointOfSale.Services.Payment {
    public class PaymentHandler {
       private Order.Order currentOrder;
    private FormPayment formPayment;


        public void GoToReceipt(bool withCard, string card) {

            if (withCard) {
                FormMain.currentOrder.PaymentMethod = "card" + card;
            }
            else {
                FormMain.currentOrder.PaymentMethod = "points";
            }
        }

        public string GetCardNumber(string cardNumber) {

            if (ValidateCardNumber(cardNumber)) {
             //   Debug.Write("Valid"); 
                return cardNumber;
            }
            else 
            {
                return "";
            }
            
        }
        public bool ValidateCardNumber(string cardNumber) {
            if (cardNumber == "" || !cardNumber.All(Char.IsDigit))
            return false; 
            CreditCardDetector detector = new CreditCardDetector(cardNumber);
            // test: 4012888888881881 
            return detector.IsValid();
    
        }
        
        public int GetRewardPoints() {
            if (CheckRewardPoints())
            {
                return GetTotalRewardPoints();
            }
            return -1; 
        }

        public bool CheckRewardPoints() 
        {
            int neededPoints = (int)FormMain.currentOrder.Total * 10;
            return neededPoints <= GetTotalRewardPoints();

        } 
        private int GetTotalRewardPoints()
        {
            return (int) FormMain.currentCustomer.RewardPoints; 
        }
       
 



    }
}
