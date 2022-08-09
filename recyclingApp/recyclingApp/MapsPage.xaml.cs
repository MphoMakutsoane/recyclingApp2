using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace recyclingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsPage : ContentPage
    {

        public MapsPage()
        {
            InitializeComponent();

            GetGeolocationAsync();

          

        }

        public async void   GetGeolocationAsync()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();

            var Latitude = location.Latitude;
            var Longitude = location.Longitude;

            var placemarks = await Geocoding.GetPlacemarksAsync(Latitude, Longitude);

            var placemark = placemarks?.FirstOrDefault();
            if (placemark != null)
            {
                var geocodeAddress =
                    $"AdminArea:       {placemark.AdminArea}\n" +
                    $"CountryCode:     {placemark.CountryCode}\n" +
                    $"CountryName:     {placemark.CountryName}\n" +
                    $"FeatureName:     {placemark.FeatureName}\n" +
                    $"Locality:        {placemark.Locality}\n" +
                    $"PostalCode:      {placemark.PostalCode}\n" +
                    $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                    $"SubLocality:     {placemark.SubLocality}\n" +
                    $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                    $"Thoroughfare:    {placemark.Thoroughfare}\n";

                //Console.WriteLine(geocodeAddress);
            }


            var options = new MapLaunchOptions { Name = "Location" };
            await Xamarin.Essentials.Map.OpenAsync(placemark, options);
        }


    }
}