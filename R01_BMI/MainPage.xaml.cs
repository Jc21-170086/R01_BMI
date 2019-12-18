using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            
            string s1 = weight.Text;
            string s2 = height.Text;
            double w = int.Parse(s1);
            double h = int.Parse(s2);
            double BMI = (w / (h * h))*10000;
            
            Label.Text = "BMI値l =" + BMI.ToString("F1");

        }
    }
}
