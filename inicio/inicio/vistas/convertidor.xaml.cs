using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace inicio.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class convertidor : ContentPage
    {
        double cm;
        double m;
        public convertidor()
        {
            InitializeComponent();
        }

        public void Calcular()
        {
            cm = Convert.ToDouble(txtcm.Text);
            m= cm/ 100;
            reslbl.Text = m.ToString() + " m";
        }

        public void validar()
        {
            if (!String.IsNullOrEmpty(txtcm.Text))
            {
                Calcular();
            }
            else{
                DisplayAlert("Error mijo","ingresa una cantidad", "De one");
            }

        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}