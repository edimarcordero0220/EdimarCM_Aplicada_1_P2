using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class ClientesTelefonosBLL
    {
       



        public static void Guardar(ClientesTelefonos ct)
        {
          
            try
            {
                 RegistroClienteDb db = new RegistroClienteDb();
                {
                    db.ClienteTelefono.Add(ct);
                    db.SaveChanges();
                    db.Dispose();
                    

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

           

        }
    }
}
