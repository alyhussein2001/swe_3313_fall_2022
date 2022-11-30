﻿using CoffeePointOfSale.Forms;
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

        public PaymentHandler() {

        }

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
            //  Debug.Assert(currentOrder.Total >= 0);
            int neededPoints = (int)FormMain.currentOrder.Total * 10;
            return neededPoints <= GetTotalRewardPoints();

        } 
        private int GetTotalRewardPoints()
        {
            return (int) FormMain.currentCustomer.RewardPoints; 
        }
       
 



    }
}
