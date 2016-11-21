using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class RegistroClienteDb : DbContext
    {
        
        public RegistroClienteDb():base ("name=ConStr")
        {
                
        }
        public virtual DbSet<ClientesD> Cliente { get; set; }
        public virtual DbSet<ClientesTelefonos> ClienteTelefono { get; set; }
        public virtual DbSet<TiposTelefonons> TipoTelefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientesD>()
                .HasMany<TiposTelefonons>(c => c.Descripcion)
                .WithMany(e => e.)
                .Map(Ge =>
                {
                    Ge.MapLeftKey("");
                    Ge.MapRightKey("");
                    Ge.ToTable("");
                });
        }
    }
