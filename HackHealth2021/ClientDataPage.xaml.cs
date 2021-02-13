using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;

namespace HackHealth2021
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientDataPage : ContentPage
    {
        public string acceleration;
        public string rotation;
        public string brightness;

        public ClientDataPage()
        {
            InitializeComponent();

            
            if (!Accelerometer.IsMonitoring)
            {
                Accelerometer.ReadingChanged += Accelerometer_ReadingChanged1;
                Accelerometer.Start(SensorSpeed.UI);
            }
            if (!OrientationSensor.IsMonitoring)
            {
                OrientationSensor.ReadingChanged += OrientationSensor_ReadingChanged;
                OrientationSensor.Start(SensorSpeed.UI);
            }

                
            Acceleration.Text = "Acceleration: 0";
            Orientation.Text = "Orientation: 0";
            Illuminance.Text = "Illuminance: N/A";
            Application.Text = "Application: N/A";
            Device.StartTimer(TimeSpan.FromMilliseconds(10000), loop2);
            bool loop2()
            {
                Device.BeginInvokeOnMainThread(() => {
                    UpdateUI();

                });
                return true;
            }

        }

        private void OrientationSensor_ReadingChanged(object sender, OrientationSensorChangedEventArgs e)
        {
            rotation = Math.Sqrt(((double)e.Reading.Orientation.X * (double)e.Reading.Orientation.X) + ((double)e.Reading.Orientation.Y * (double)e.Reading.Orientation.Y) + ((double)e.Reading.Orientation.Z * (double)e.Reading.Orientation.Z)).ToString();
        }



        public void UpdateUI()
        {
            
            
            Acceleration.Text = "Acceleration: " + acceleration;
            Orientation.Text = "Orientation: " + rotation;
            Illuminance.Text = "Illuminance: N/A";
            Application.Text = "Application: N/A";
        }

        private void Accelerometer_ReadingChanged1(object sender, AccelerometerChangedEventArgs e)
        {
            acceleration = Math.Sqrt(((double)e.Reading.Acceleration.X * (double)e.Reading.Acceleration.X) + ((double)e.Reading.Acceleration.Y * (double)e.Reading.Acceleration.Y) + ((double)e.Reading.Acceleration.Z * (double)e.Reading.Acceleration.Z)).ToString();
        }



        /*
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }*/
        /* async void Button_Clicked(object sender, EventArgs e)
         {

             await App.Database.SavePersonAsync(new Patient
             {
                 TestResult = "20",
                 ComputedResult = "54"

             }) ;


                 collectionView.ItemsSource = await App.Database.GetPeopleAsync();

         }*/
    }
}