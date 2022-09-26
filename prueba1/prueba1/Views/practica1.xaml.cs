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
    public partial class practica1 : ContentPage
    {
        public practica1()
        {
            InitializeComponent();
        }

        public async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Contenido1());
        }
    }
}