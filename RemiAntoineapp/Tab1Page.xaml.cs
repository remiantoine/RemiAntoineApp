using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace RemiAntoineApp
{
    partial class Tab1Page : ContentPage
    {
        public Tab1Page()
        {
            InitializeComponent();
        }
        private async void PlayButton_Clicked(object sender, EventArgs e)
        {
            // Navigation vers la nouvelle page
            await Shell.Current.Navigation.PushAsync(new GifPage());
        }


    }

}
