using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prueba1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PruebasPag : ContentPage
    {
        public PruebasPag()
        {
            InitializeComponent();
        }

        private void Alert1_Clicked(object sender, EventArgs e)
        {

        }

        private async void Alert2_Clicked(object sender, EventArgs e)
        {
            bool resp = await DisplayAlert("Message", "Cambio de color", "Si", "No");
            if (resp == true)
            {
                color.BackgroundColor = Color.Black;
            }
            else
            {
                color.BackgroundColor = Color.AliceBlue;
            }

        }

        private async void Alert3_Clicked(object sender, EventArgs e)
        {
            String respuesta = await DisplayActionSheet("Escoger un fondo", "Cancelar","", "Rojo", "Azul", "Verde");
        
          switch (respuesta)
            {
                case "Rojo":
                    color.BackgroundColor = Color.Red;
                    break;
                case "Azul":
                    color.BackgroundColor = Color.Blue;
                    break;
                case "Verde":
                    color.BackgroundColor = Color.Green;
                    break;
            }
        }

        private async void CuartaPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new webViews());
        }
    }
}