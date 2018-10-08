using Plugin.SimpleAudioPlayer;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YS1.Models;


namespace YS1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartGame : ContentPage
	{
        ISimpleAudioPlayer note_player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

        

        private static int _stage;
        Stages stages;
        static Random digit_random = new Random();                     
        
        public StartGame ()
		{            
            InitializeComponent();
            _stage = 1;                                    

        } // Start Game
        
        private void Clear_UserInput(object sender, EventArgs e)
        {
            userinput_display.Text = "";
        }

        async void Show_Mission()
        {
            stages = new Stages(_stage); // Generate Random Pattern with length input
            for (int i = 0; i < _stage; i++)
            {
                mission_display.Text = stages.Mission_String[i];
                Play_Sound(mission_display.Text);
                await Task.Delay(1000);
            }
        }

        private void Play_Sound(string num)
        {
            string FileName = "";
            if (num == "1")
            {
                FileName = "c1.wav";
            }
            else if(num == "2")
            {
                FileName = "d1.wav";
            }
            else if (num == "3")
            {
                FileName = "e1.wav";
            }
            else if (num == "4")
            {
                FileName = "f1.wav";
            }
            else if (num == "5")
            {
                FileName = "g1.wav";
            }
            else if (num == "6")
            {
                FileName = "a1.wav";
            }
            else if (num == "7")
            {
                FileName = "b1.wav";
            }
            note_player.Load(FileName);
            note_player.Play();
        }


        private void Check_Answer(object sender, EventArgs e)
        {
            stages.User_String = userinput_display.Text;

            userinput_display.Text = "";
            mission_display.Text = "";            

            if (stages.CheckAnswer())
            {
                DisplayAlert("ANSWER", "CORRECT", "OK");
            }
            else
            {
                DisplayAlert("ANSWER", "TRY AGAIN", "OK");
            }

        }
        
        private void Clear_Stage(object sender, EventArgs e)
        {
            mission_display.Text = "";
            cur_stage.Text = "1";
            _stage = 1;
        }

        private void Number_UserInput(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            userinput_display.Text = userinput_display.Text + b.Text;
        }
        
        private void stage_minus(object sender, EventArgs e)
        {
            _stage--;
            if (_stage < 1) { _stage = 1; }
            cur_stage.Text = _stage.ToString();
        }
        private void stage_plus(object sender, EventArgs e)
        {
            _stage++;
            cur_stage.Text = _stage.ToString();
        }

       
    }
}