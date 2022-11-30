using Newtonsoft.Json;


namespace CoffeePointOfSale.Services.DrinkMenu {
    public class DrinkMenu {
        [JsonProperty("DrinkMenu")]
        private readonly Dictionary<string, Drink> _drinkDict = new();

        [JsonIgnore]
        public IReadOnlyList<Drink> List =>
        _drinkDict.Select(c => c.Value)
            .ToList();
    }
}
