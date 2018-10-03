using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Plugin.SimpleAudioPlayer;

namespace YS1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Music : ContentPage
	{
        ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
        
        public Music ()
		{
			InitializeComponent ();
            player.Load("rainandtears.mp3");
            
		}

        private void Button_Clicked(object sender, EventArgs e) // play
        {
            player.Play();
        }

        private void Button_Clicked_1(object sender, EventArgs e) // pause
        {
            player.Pause();
        }

        private void Button_Clicked_2(object sender, EventArgs e) // stop
        {
            player.Stop();
        }
    }
}