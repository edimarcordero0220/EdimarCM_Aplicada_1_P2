using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientesD
    {
        

        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        //public virtual ICollection<ClientesD> cliente { get; set; }
        //public DateTime FechaNacimiento { get; set; }
        public string LimiteCredito { get; set; }
        //public ICollection<TiposTelefonons> Descripcion { get; set; }
    }
}
