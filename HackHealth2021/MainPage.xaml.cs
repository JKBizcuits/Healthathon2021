using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace HackHealth2021
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }

       /* async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(firstNameEntry.Text) && !string.IsNullOrWhiteSpace(lastNameEntry.Text))
            {
                await App.Database.SavePersonAsync(new Patient
                {
                    FirstName = firstNameEntry.Text,
                    LastName = lastNameEntry.Text
                });

                firstNameEntry.Text = lastNameEntry.Text = string.Empty;
                collectionView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }*/



        private void Button_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new PatientMain();
            Navigation.PushAsync(new ForkPage());
        }
    }
}
