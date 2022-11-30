using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormManagement : FormNoCloseBase
{
    private readonly ICustomerService _customerService;
    private IAppSettings _appSettings;

    public FormManagement(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
    {
        _customerService = customerService;
        _appSettings = appSettings;
        InitializeComponent();
    }

    private void OnClickBtnClose(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

    /// <summary>
    /// Remove this from your project... here to show you how to get the customer list
    /// </summary>
    

    private void OnLoadFormManagement(object sender, EventArgs e)
    {
        
    }

    private void txtDeleteThis_TextChanged(object sender, EventArgs e)
    {

    }

    private void bCSV_Click(object sender, EventArgs e)
    {

    }
}