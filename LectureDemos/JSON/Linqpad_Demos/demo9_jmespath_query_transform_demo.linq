<Query Kind="Program">
  <NuGetReference>JmesPath.Net</NuGetReference>
  <Namespace>DevLab.JmesPath</Namespace>
  <Namespace>System.Text.Json</Namespace>
</Query>

void Main()
{
	var input = "{\"Customers\":[{\"CustomerId\":1000,\"Identification\":{\"Email\":\"Jeff@Rocks.com\",\"Phone\":\"404-444-1234\",\"NameLast\":\"Jeff\",\"NameFirst\":\"Adkisson\"},\"Address\":{\"Company\":\"\",\"Street1\":\"777 Angry Road\",\"Street2\":\"Suite 540\",\"Street3\":\"\",\"City\":\"Marietta\",\"State\":\"GA\",\"PostalCode\":\"30068\",\"Notes\":\"His children are evil - do NOT approach or make eye contact\"},\"Payment\":{\"PaymentMethodIdAllowed\":[1,2],\"CreditCard\":{\"Type\":\"Visa\",\"Number\":\"123-123-123-123\",\"ExpiresYear\":2022,\"ExpiresMonth\":12,\"SecurityCode\":555}}}],\"MenuItems\":[{\"MenuItemId\":1,\"Name\":\"Pizza\",\"IsTopLevelItem\":true,\"Price\":10.99,\"MenuItemIdAddOns\":[2,3,4,5,6]},{\"MenuItemId\":3,\"Name\":\"Medium Size\",\"IsTopLevelItem\":false,\"Price\":2,\"MenuItemIdAddOns\":[]},{\"MenuItemId\":3,\"Name\":\"Large Size\",\"IsTopLevelItem\":false,\"Price\":4,\"MenuItemIdAddOns\":[]},{\"MenuItemId\":4,\"Name\":\"Extra Cheese\",\"IsTopLevelItem\":false,\"Price\":1.5,\"MenuItemIdAddOn\":[]},{\"MenuItemId\":5,\"Name\":\"Pepperoni\",\"IsTopLevelItem\":false,\"Price\":2,\"MenuItemIdAddOns\":[]},{\"MenuItemId\":6,\"Name\":\"Buffalo Chicken\",\"IsTopLevelItem\":false,\"Price\":2,\"MenuItemIdAddOn\":[]}],\"PaymentMethods\":[{\"PaymentMethodId\":1,\"Name\":\"Cash\"},{\"PaymentMethodId\":2,\"Name\":\"Credit Card\"},{\"PaymentMethodId\":3,\"Name\":\"Check\"}],\"Orders\":[{\"OrderId\":1,\"CustomerId\":1000,\"PaymentMethodId\":2,\"OrderedOn\":\"3/9/2022 5:00 PM\",\"IsDelivery\":true,\"MenuIdSelections\":[{\"MenuItemId\":1,\"Quantity\":1,\"MenuItemIdAddOns\":[3,4,4,5]}],\"Price\":{\"Subtotal\":24.99,\"TaxRate\":0.06,\"Total\":26.49}}]}";
	const string expression = "MenuItems[?Price <= `5` && Price >= `2`].{ name: Name, price: Price } | sort_by(@, &price)";

	var jmes = new JmesPath();
	var result = jmes.Transform(input, expression);

	if (result != null)
	{
		var parsedResult = JsonDocument.Parse(result);
		var prettyPrintedResult = JsonSerializer.Serialize(
			parsedResult, 
			new JsonSerializerOptions { WriteIndented = true }
		);
		prettyPrintedResult.Dump($"Query result: {expression}");
	}
}
