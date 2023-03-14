using Ejercicio_3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio_3.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaPage : ContentPage
    {
        public VistaPage()
        {
            InitializeComponent();
        }

        private void Registrar(object sender, EventArgs e)
        {
            var pageform = new Vistas.RegistroPage();
            Navigation.PushAsync(pageform);
        }

        private void Registro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Registros.ItemsSource = await App.DBRegistro.GetlistRegistro;

        }
    }
}