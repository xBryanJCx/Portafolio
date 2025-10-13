using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.ObtenerListaDeRepuestos;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.ObtenerListaDeRepuestos
{
	public class ObtenerListaDeRepuestosAD : IObtenerListaDeRepuestosAD
	{
		private Contexto _elContexto;
		public ObtenerListaDeRepuestosAD()
		{
			_elContexto = new Contexto();
		}

		public List<InventarioDto> Obtener()
		{
			List<InventarioDto> laListaDelInventario = (from inventario in _elContexto.Inventarios
														//join adjutos in _elContexto.Adjuntos on inventario.id equals adjuntos.IdRepuesto
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
															vehiculo = inventario.vehiculo	,
															//adjunto = adjutos.adjunto
														}).ToList();
			return laListaDelInventario;
		}
	}
}
