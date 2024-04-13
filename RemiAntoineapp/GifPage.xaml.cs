using Microsoft.Maui.Controls;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Threading.Tasks;
namespace RemiAntoineApp
{
    public partial class GifPage : ContentPage
    {
        public GifPage()
        {
            InitializeComponent();

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
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(100);
            GifImage.IsAnimationPlaying = false;
            await Task.Delay(100);
            GifImage.IsAnimationPlaying = true;
        }
    }
}
