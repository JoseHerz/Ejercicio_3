using Ejercicio_3.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Ejercicio_3.Modelos;
using System.Threading.Tasks;

namespace Ejercicio_3.Controlador
{
    public class RegistroController
    {
        readonly SQLiteAsyncConnection connection;

        public RegistroController(String dbpath)
        {
            connection = new SQLiteAsyncConnection(dbpath);

            connection.CreateTableAsync<Registro>().Wait();

        }


        //operaciones CRUD//

        public Task<int> SaveRegistro(Registro registro)
        {
            if (registro.id != 0)
                return connection.UpdateAsync(registro);
            else
                return connection.InsertAsync(registro);
        }

        public Task<List<Registro>> GetlistRegistro()
        {
            return connection.Table<Registro>().ToListAsync();
        }

        public Task<Registro> GetRegistro(int pid)
        {
            return connection.Table<Registro>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> DeleteRegistro(Registro registro)
        {
            return connection.DeleteAsync(registro);
        }

    }
}
