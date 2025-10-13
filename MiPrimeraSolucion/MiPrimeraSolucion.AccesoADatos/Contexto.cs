using MiPrimeraSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos
{
	public class Contexto : DbContext
	{
		public Contexto()
		{
			Database.SetInitializer<Contexto>(null);
		}
		public DbSet<InventarioDA> Inventarios { get; set; }
	}
}
