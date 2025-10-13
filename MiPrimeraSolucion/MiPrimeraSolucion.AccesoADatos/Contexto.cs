using MiPrimeraSolucion.AccesoADatos.Entidades;
using System.Data.Entity;

namespace MiPrimeraSolucion.AccesoADatos
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
            Database.SetInitializer<Contexto>(null);
        }
        public DbSet<InventarioDA> Inventarios { get; set; }
        public DbSet<ClientesDA> Clientes { get; set; }
    }
}
