using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormMain : FormBase
{

    public static Services.Customer.Customer currentCustomer;
    public static Services.Order.Order currentOrder;

    private readonly ICustomerService _customerService;

    public FormMain(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
    {
        InitializeComponent();
        _customerService = customerService;
    }

    private void OnClickBtnManagement(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormManagement>().Show();
    }

    private void OnFormMainClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        var customerList = _customerService.Customers.List;
        foreach (Customer customer in customerList) {
            if (customer.Phone == "anonymous") {
                FormMain.currentCustomer = customer;
            }
        }
    }

    private void bOrderDrink_Click(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormOrderDrink>().Show();
    }

    private void bCustList_Click(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormCustomerList>().Show();
    }
}