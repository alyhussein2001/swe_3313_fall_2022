using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;

    public DrinkMenu DrinkMenu { get; init; }

    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;
        DrinkMenu = _storageService.Read<DrinkMenu>();
    }

    public void Write() => _storageService.Write(DrinkMenu);


}