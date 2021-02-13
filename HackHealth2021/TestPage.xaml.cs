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
    public partial class TestPage : ContentPage
    {
        public string MyProperty { get; set; } = "Result";
        int score = 0;


        public TestPage()
        {
            InitializeComponent();

            
        }
        protected override bool OnBackButtonPressed()
        {
            //App.Current.MainPage = new MainPage();
            Navigation.PopAsync();
            return base.OnBackButtonPressed();
        }
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                score+=selectedIndex;
               
            }

        }
        private void Button_Clicked(object sender, EventArgs e)
        {



            Navigation.PopAsync();
        }
    }
}