using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackHealth2021
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TherapistMain : ContentPage
    {
        public TherapistMain()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClientDataPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Error", "Client's info cannot be reached at this time", "OK");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("Error", "New clients cannot be added at this time", "OK");
        }
    }
}