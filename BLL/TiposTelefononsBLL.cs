using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class TiposTelefononsBLL
    {
        public static void Insertar(TiposTelefonons t)
        {

            try
            {
                RegistroClienteDb db = new RegistroClienteDb();
                {
                    db.TipoTelefono.Add(t);
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
