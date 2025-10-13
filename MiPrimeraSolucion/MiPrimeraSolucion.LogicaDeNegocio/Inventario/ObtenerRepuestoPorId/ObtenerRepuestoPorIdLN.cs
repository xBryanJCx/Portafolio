using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerRepuestoPorId;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerRepuestoPorId;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using MiPrimeraSolucion.AccesoADatos.Inventario.ObtenerRepuestoPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.ObtenerRepuestoPorId
{
	public class ObtenerRepuestoPorIdLN : IObtenerRepuestoPorIdLN
	{
		private IObtenerRepuestoPorIdAD _obtenerRepuestoPorIdAD;

		public ObtenerRepuestoPorIdLN()
		{
			_obtenerRepuestoPorIdAD = new ObtenerRepuestoPorIdAD();
		}

		public InventarioDto Obtener(int idDelRepuesto)
		{
			return _obtenerRepuestoPorIdAD.Obtener(idDelRepuesto);
		}
	}
}
