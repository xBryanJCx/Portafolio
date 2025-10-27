using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrayanJaenContreras.AccesoADatos.Entidades;


namespace BrayanJaenContreras.AccesoADatos
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=CasoPractico")
        {
            Database.SetInitializer<Contexto>(null);
        }

        public DbSet<HabitacionDA> Habitaciones { get; set; }
        public DbSet<ReservaDA> Reservas { get; set; }
    }
}
