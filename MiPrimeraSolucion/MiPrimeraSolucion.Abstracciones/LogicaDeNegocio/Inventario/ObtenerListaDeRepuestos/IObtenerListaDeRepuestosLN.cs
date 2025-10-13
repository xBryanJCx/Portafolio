using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerListaDeRepuestos
{
	public interface IObtenerListaDeRepuestosLN
	{
		List<InventarioDto> Obtener();
	}
}
