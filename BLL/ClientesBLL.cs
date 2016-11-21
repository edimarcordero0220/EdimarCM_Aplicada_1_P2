using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class ClientesBLL
    {
        

        public static void Guardar(ClientesD c)
        {

            try
            {
                RegistroClienteDb db = new RegistroClienteDb();
                {

                    db.Cliente.Add(c);
                    db.SaveChanges();
                    db.Dispose();


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static ClientesD Buscar(int ClienteId)
        {
            ClientesD cliente = new ClientesD();
            using (RegistroClienteDb db = new RegistroClienteDb())
            {
                try
                {
                    cliente = db.Cliente.Find(ClienteId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return cliente;
        }
        public static List<ClientesD> GetLista()
        {

            List<ClientesD> lista = new List<ClientesD>();
            using (RegistroClienteDb conexion = new RegistroClienteDb())
            {
                bool pas = false;
                try
                {
                    lista = conexion.Cliente.ToList();
                    pas = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            return lista;

        }

        public static void Eliminar(int Id)
        {
            var db = new RegistroClienteDb();
            ClientesD e = db.Cliente.Find(Id);
            db.Cliente.Remove(e);
            db.SaveChanges();
        }
    }
}

