using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.Order;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.CSVExtract
{
    public class CSVExtract
    {
        private ICustomerService _customerService;
        public CSVExtract(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Extract()
        {
            IReadOnlyList<Customer.Customer> customers = _customerService.Customers.List;
            var csvExtractLines = new List<CsvExtractLine>(); //contains CSV extract data

            //loop through each customer and each order - output will have N customers * M orders lines
            //for example, 5 customers each with 5 orders will produce 25 lines of output
            foreach (var customer in customers)
            {
                foreach (var order in customer.OrderHistory)
                {
                    var csvExtractLine = new CsvExtractLine
                    {
                        CustomerId = customer.Phone,
                        CustomerName = customer.FirstName + "," + customer.LastName,
                        OrderDate = order.TransactionDate,
                        OrderTotalPrice = order.Total,
                        OrderDetails = order.ToString()
                    };

                    csvExtractLines.Add(csvExtractLine);
                }
            }

            //set path and filename
            var outputDirectory = Path.GetTempPath(); //find OS temp directory
            var csvFilename = $"output_{DateTime.Now.Ticks}.csv";
            var csvPathAndFilename = Path.Join(outputDirectory, csvFilename);

            //write csvExtractLines via CSVHelper
            using (var writer = new StreamWriter(csvPathAndFilename))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(csvExtractLines);
            }

            //attempt to open in Excel (or whatever is registered to open .csv files on the machine)
            try
            {
                var processStartInfo = new ProcessStartInfo(csvPathAndFilename)
                {
                    WorkingDirectory = outputDirectory,
                    UseShellExecute = true
                };
                Process.Start(processStartInfo);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open [{csvPathAndFilename}]: {ex.Message}");
            }
        }
    }

    public class CsvExtractLine
    {
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotalPrice { get; set; }
        public string? OrderDetails { get; set; }
    }
}
