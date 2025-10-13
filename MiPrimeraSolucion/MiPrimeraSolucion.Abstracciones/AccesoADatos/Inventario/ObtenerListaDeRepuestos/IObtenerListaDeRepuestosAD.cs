using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerListaDeRepuestos
{
	public interface IObtenerListaDeRepuestosAD
	{
		List<InventarioDto> Obtener();
	}
}
