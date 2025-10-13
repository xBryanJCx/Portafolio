using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerListaDeRepuestos;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerListaDeRepuestos;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using MiPrimeraSolucion.AccesoADatos.Inventario.ObtenerListaDeRepuestos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.ObtenerListaDeRepuestos
{
	public class ObtenerListaDeRepuestosLN: IObtenerListaDeRepuestosLN
	{
		private readonly IObtenerListaDeRepuestosAD _obtenerListaDeRepuestosAD;
		public ObtenerListaDeRepuestosLN()
		{
			_obtenerListaDeRepuestosAD = new ObtenerListaDeRepuestosAD();
		}
		public List<InventarioDto> Obtener()
		{
			List<InventarioDto> laListaDeInventario = _obtenerListaDeRepuestosAD.Obtener();
			return laListaDeInventario;
		}
	}
}
