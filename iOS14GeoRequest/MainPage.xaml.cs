using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace iOS14GeoRequest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var request = new GeolocationRequest(GeolocationAccuracy.Medium)
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            var location = await Geolocation.GetLocationAsync(request);

            await DisplayAlert("Lat Lng", $"{location.Latitude} {location.Longitude}", "Ok");
        }
    }
}