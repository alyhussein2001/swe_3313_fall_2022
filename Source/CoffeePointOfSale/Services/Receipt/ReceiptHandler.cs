using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.Receipt {
    public class ReceiptHandler {
        private Order.Order currentOrder;
        private Form receiptScreenForm;
        public ReceiptHandler() { 
        
        }

        public void GoToMainMenu() {
            // go back to MainForm
        }

        private void DisplayHeader() {
            //display customer info, etc. shown on receipt screen in prototype on form element
        }

        private void DisplayCurrentOrder() {
            //display current order info in form element
        }

        private void DisplayPrices() {
            //display prices on form element 
        }
    }
}
