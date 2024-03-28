using Microsoft.Maui.Controls;
using System.Timers;
using Timer = System.Timers.Timer;

namespace RemiAntoineapp
{
    internal class GifPage : ContentPage
    {
        public GifPage()
        {

            StartTimer();
        }

        private void StartTimer()
        {
            // Démarre une minuterie avec un délai de 5 secondes (5000 millisecondes)
            Timer timer = new Timer(5000);
            timer.Elapsed += async (sender, e) =>
            {
                // Arrête la minuterie
                timer.Stop();

                // Retourne à la première page
                await Shell.Current.Navigation.PopAsync();
            };
            timer.AutoReset = false; // S'assure que la minuterie ne se répète pas
            timer.Start();
        }
    }
}
