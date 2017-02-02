using System;
using Xamarin.Forms;

namespace Greetings
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            Padding = Device.OnPlatform<Thickness>(
                new Thickness(0, 20, 0, 0), // iOS
                new Thickness(0), // Android
                new Thickness(0) // WinPhone
                );

            var MyLabel = new Label();
            MyLabel.Text = "Greetings, Xamarin.Forms!";
            this.Content = MyLabel;

            //MyLabel.HorizontalOptions = LayoutOptions.Center;
            //MyLabel.VerticalOptions = LayoutOptions.Center;

            MyLabel.HorizontalTextAlignment = TextAlignment.Center;
            MyLabel.VerticalTextAlignment = TextAlignment.Center;
        }
    }
}
