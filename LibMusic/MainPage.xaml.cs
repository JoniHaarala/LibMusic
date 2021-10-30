using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace LibMusic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AnimateCarousel();
        }

        Timer timer;

        private void AnimateCarousel()
        {
            timer = new Timer(4000) { AutoReset= true, Enabled= true };
            timer.Elapsed += (e, s) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    if (cvOnboarding.Position == 2)//revisamos si la posicion del carrusel es el final
                    {
                        cvOnboarding.Position = 0; // reseteamos el carrusel
                        return;
                    }
                    cvOnboarding.Position += 1;
                });
            };
        }
    }
}
