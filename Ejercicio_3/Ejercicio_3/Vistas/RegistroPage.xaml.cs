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
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

        private async void Ver(object sender, EventArgs e)
        {

            var registro = new Modelos.Registro
            {
                nombres = Nombre.Text,
                apellidos = Apellido.Text,
                edad = int.Parse(Edad.Text),
                correo = Correo.Text,
                direccion = Direccion.Text
            };

            var page = new Vistas.BasePage();
            page.BindingContext = registro;
            await Navigation.PushAsync(page);

        }

        private void Limpiar(object sender, EventArgs e)
        {

            Nombre.Text = "";
            Apellido.Text = "";
            Edad.Text = "";
            Correo.Text = "";
            Direccion.Text = "";
        }
    }
}