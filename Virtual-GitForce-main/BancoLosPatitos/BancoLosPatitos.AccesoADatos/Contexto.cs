using BancoLosPatitos.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=Contexto")
        {
            Database.SetInitializer<Contexto>(null);
        }

        public DbSet<ComerciosDA> Comercios { get; set; }

        public DbSet<CajasDA> Cajas { get; set; }

        public DbSet<SinpesDA> Sinpes { get; set; }
    }
}
