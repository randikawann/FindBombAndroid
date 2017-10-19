using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test1007
{
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1,4).ToString();
        static int score=0;
        public MainPage()
        {
            InitializeComponent();
        }
        async void ButtonClicked(object sender, EventArgs e) {
            Button button = sender as Button;

            //Game over
            if (button.Text == bomb) {
                await DisplayAlert("Bomb exploded","GAME OVER", "Retry");
                bomb = new Random().Next(1,4).ToString();
                score = 0;
            }
            else
            {
                score += 1;
                await DisplayAlert("Bomb defused", "Scores:" + score, "continue");
                bomb = new Random().Next(1, 4).ToString();
            }
        }
    }
}
