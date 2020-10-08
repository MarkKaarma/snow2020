using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace snow2020
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void verhiy_Clicked(object sender, EventArgs e)
        {
            golov.BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), 0);
            verh.BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), 0);
            seredina.BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), 0);
            vniz.BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), 0);
        }

        private void cleaning_Clicked(object sender, EventArgs e)
        {
            verh.BackgroundColor = Color.FromHex("#F9F9F9");
            seredina.BackgroundColor = Color.FromHex("#F9F9F9");
            vniz.BackgroundColor = Color.FromHex("#F9F9F9");
        }

        private void down_Clicked(object sender, EventArgs e)
        {
            golov.Opacity = 0;
            verh.Opacity = 0;
            seredina.Opacity = 0;
            vniz.Opacity = 0;
        } 

        private void show_Clicked(object sender, EventArgs e)
        {
            golov.Opacity = 1;
            verh.Opacity = 1;
            seredina.Opacity = 1;
            vniz.Opacity = 1;
        }

        private void poka_Clicked(object sender, EventArgs e)
        {
            // Нужен код, как сделать так, чтобы работало чтобы снеговик "растопился", т.е. одна частичка пропадает через +-2 секунды.
        }
    }
}
