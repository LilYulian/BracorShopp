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
    public partial class Contenido1 : ContentPage
    {
        public Contenido1()
        {
            InitializeComponent();
        }

        private async void btnVolverInicio_Clicked(object sender, EventArgs e)
        {
           await Navigation.PopAsync();
        }

        private async void BTnGuardado_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "Se a guardado correctamente", "Cerrar");
        }

        private async void TrceraPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PruebasPag());
        }
    }
}