using CommunityToolkit.Mvvm.ComponentModel;
using Models;
using System.Collections.ObjectModel;

namespace ImHungryNow.Views;

public partial class RestaurantMenuView : ContentPage
{

    public RestaurantMenuView()
	{
		InitializeComponent();

        BindingContext = new RestaurantMenuViewModel();
    }
}