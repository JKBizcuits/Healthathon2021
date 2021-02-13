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
    public partial class ForkPage : ContentPage
    {
        public ForkPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TherapistMain());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PatientMain());
        }

        protected override bool OnBackButtonPressed()
        {
            //App.Current.MainPage = new MainPage();
            Navigation.PopAsync();
            return base.OnBackButtonPressed();
        }
    }
}