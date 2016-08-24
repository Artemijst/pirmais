using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class otralapa : ContentPage
    {
        public otralapa()
        {
            InitializeComponent();
        }

        private void button_Onclicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
