using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YS1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartGame : ContentPage
	{
        private int _stage = 0;
        public StartGame ()
		{
            InitializeComponent();
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            display.Text = "0";
            _stage = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _stage++;
            display.Text = _stage.ToString();
        }
    }
}