using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Procesos
    {
        public string Guardar(Persona persona)
        {
            string connectionString = "";
            
            try { 
            //SQlServer db = new SQlServer(connectionString);

            //db.Open();

            //string sql = $"Insert into Personas ( Nombre, Apellido) values ('{persona.Nombre}','{persona.Apellido}')";
            string sql = $"select * from personas";
                //db.ExecuteNonQuery(sql);
            } catch(   Exception e)
            {
                return "No se puede guardar los datos";
            }

            return "Guardado Correctamente";

            //.
            //.
            //.
            //.
        }
    }
}
