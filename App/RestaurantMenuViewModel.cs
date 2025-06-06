using CommunityToolkit.Mvvm.ComponentModel;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImHungryNow;

public partial class RestaurantMenuViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Product> products = new();

    public RestaurantMenuViewModel()
    {
        products.Add(new()
        {
            name = "Hamburguer",
            description = "Hamburguer muito bom",
            price = 10
        });

        products.Add(new()
        {
            name = "X-Burguer",
            description = "Mais queijo, mais sabor",
            price = 12
        });

        products.Add(new()
        {
            name = "X-Salada",
            description = "Com alface e tomate",
            price = 11
        });
    }
}
