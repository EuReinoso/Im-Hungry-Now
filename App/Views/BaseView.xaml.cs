namespace ImHungryNow.Views;

public partial class BaseView : ContentPage
{
    int count = 0;

    public BaseView()
    {
        InitializeComponent();
        Navigation.PushAsync(new RestaurantMenuView());
    }
}