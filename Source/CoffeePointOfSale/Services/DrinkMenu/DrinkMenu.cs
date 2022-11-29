using Newtonsoft.Json;


namespace CoffeePointOfSale.Services.DrinkMenu {
    public class DrinkMenu {
        [JsonProperty("DrinkMenu")]
        private readonly Dictionary<string, Drink> _drinkDict = new();

        [JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
        public IReadOnlyList<Drink> List =>
        _drinkDict.Select(c => c.Value)
            .ToList();


    }
}
