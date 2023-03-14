using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Ejercicio_3
{
    public partial class App : Application
    {
        static Controlador.RegistroController dbRegistro;
        public static Controlador.RegistroController DBRegistro
        {
            get
            {
                if (dbRegistro == null)
                {
                    var dbpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "Registro.db3";
                    dbRegistro = new Controlador.RegistroController(Path.Combine(dbpath, dbname));

                }
                return dbRegistro;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
