using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace YS1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnStart.Clicked += (s, e) => Navigation.PushAsync(new StartGame());
            btnScore.Clicked += (s, e) => Navigation.PushAsync(new LeaderBoard());
            btnDeveloper.Clicked += (s, e) => Navigation.PushAsync(new Developer());
            btnMusic.Clicked += (s, e) => Navigation.PushAsync(new Music());
        }

    }
}
