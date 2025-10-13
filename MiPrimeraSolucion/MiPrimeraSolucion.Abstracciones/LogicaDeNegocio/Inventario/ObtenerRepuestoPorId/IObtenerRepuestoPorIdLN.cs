using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerRepuestoPorId
{
	public interface IObtenerRepuestoPorIdLN
	{
		InventarioDto Obtener(int idDelRepuesto);
	}
}
