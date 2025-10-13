using MiPrimeraSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.EliminarRepuesto
{
	public class EliminarRepuestoAD
	{
		private Contexto _elContexto;

		public EliminarRepuestoAD()
		{
			_elContexto = new Contexto();
		}
		public int Eliminar(int idDelRepuestoAEliminar)
		{
			InventarioDA elRepuestoAEliminar = _elContexto.Inventarios.FirstOrDefault(repuesto => repuesto.id == idDelRepuestoAEliminar);
			if (elRepuestoAEliminar == null)
			{
				return 0;
			}
			_elContexto.Inventarios.Remove(elRepuestoAEliminar);
			int cantidadDeFilasAfectadas = _elContexto.SaveChanges();
			return cantidadDeFilasAfectadas;
		}
	}
}
