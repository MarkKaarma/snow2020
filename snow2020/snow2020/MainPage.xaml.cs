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
            int c = rnd.Next(1, 4);
            if (c == 1)
            {
                verh.BackgroundColor = Color.FromHex("#347EB8");
                seredina.BackgroundColor = Color.FromHex("#343CB8");
                vniz.BackgroundColor = Color.FromHex("#240689");
            }
            else if (c == 2)
            {
                verh.BackgroundColor = Color.FromHex("#A19FA7");
                seredina.BackgroundColor = Color.FromHex("#63606D");
                vniz.BackgroundColor = Color.FromHex("#505052");
            }
            else
            {
                verh.BackgroundColor = Color.FromHex("#9EBC16");
                seredina.BackgroundColor = Color.FromHex("#748A10");
                vniz.BackgroundColor = Color.FromHex("#EAE309");
            }
        }

        private void cleaning_Clicked(object sender, EventArgs e)
        {
            verh.BackgroundColor = Color.FromHex("#F9F9F9");
            seredina.BackgroundColor = Color.FromHex("#F9F9F9");
            vniz.BackgroundColor = Color.FromHex("#F9F9F9");
        }
    }
}
