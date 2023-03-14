using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ejercicio_3.Modelos
{
    public class Registro
    {

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(100)]
        public string nombres { get; set; }
        [MaxLength(100)]
        public string apellidos { get; set; }
        [MaxLength(3)]
        public int edad { get; set; }
        [MaxLength(100)]
        public string correo { get; set; }
        [MaxLength(200)]
        public string direccion { get; set; }


    }
}
