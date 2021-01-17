using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselBug
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel thisViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            thisViewModel = new MainPageViewModel();
            this.BindingContext = thisViewModel;

            if (thisViewModel != null)
            {
                thisViewModel.OnAppearing();
            }
        }
    }
}
