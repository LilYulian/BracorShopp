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

        private void btnVolverInicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        
    }
}