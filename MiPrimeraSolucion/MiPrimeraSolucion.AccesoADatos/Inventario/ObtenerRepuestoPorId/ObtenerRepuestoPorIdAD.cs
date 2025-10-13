using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerRepuestoPorId;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.ObtenerRepuestoPorId
{
	public class ObtenerRepuestoPorIdAD: IObtenerRepuestoPorIdAD
	{
		private Contexto _elContexto;
		public ObtenerRepuestoPorIdAD()
		{
			_elContexto = new Contexto();
		}
		public InventarioDto Obtener(int idDelRepuesto)
		{
			InventarioDto elRepuesto = (from inventario in _elContexto.Inventarios
										where inventario.id == idDelRepuesto
										select new InventarioDto
														{
															id = inventario.id,
															anio = inventario.anio,
															cantidad = inventario.cantidad,
															codigoDelRepuesto = inventario.codigoDelRepuesto,
															estado = inventario.estado,
															fechaDeModificacion = inventario.fechaDeModificacion,
															fechaDeRegistro = inventario.fechaDeRegistro,
															marcaDelRepuesto = inventario.marcaDelRepuesto,
															modelo = inventario.modelo,
															nombreDelRepuesto = inventario.nombreDelRepuesto,
															vehiculo = inventario.vehiculo,
														}).FirstOrDefault();
			return elRepuesto;
		}
	}
}
