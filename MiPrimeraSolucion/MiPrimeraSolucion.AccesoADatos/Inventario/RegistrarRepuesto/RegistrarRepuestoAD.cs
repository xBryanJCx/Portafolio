using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.RegistrarRepuesto;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using MiPrimeraSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.RegistrarRepuesto
{
	public class RegistrarRepuestoAD : IRegistrarRepuestoAD
	{
		private Contexto _elContexto;

		public RegistrarRepuestoAD()
		{
			_elContexto = new Contexto();
		}

		public async Task<int> Registrar(InventarioDto elInventarioAGuardar)
		{
			InventarioDA inventarioConvertidoEnEntidad = ConvertirObjetoAEntidad(elInventarioAGuardar);
			_elContexto.Inventarios.Add(inventarioConvertidoEnEntidad);
			int cantidadDeFilasAfectadas = await _elContexto.SaveChangesAsync();
			return cantidadDeFilasAfectadas;
		}

		private InventarioDA ConvertirObjetoAEntidad(InventarioDto elInventarioAGuardar)
		{
			return new InventarioDA {
				anio = elInventarioAGuardar.anio,
				cantidad = elInventarioAGuardar.cantidad,
				codigoDelRepuesto = elInventarioAGuardar.codigoDelRepuesto,
				estado = elInventarioAGuardar.estado,
				fechaDeModificacion = elInventarioAGuardar.fechaDeModificacion,
				fechaDeRegistro = elInventarioAGuardar.fechaDeRegistro,
				marcaDelRepuesto = elInventarioAGuardar.marcaDelRepuesto,
				modelo = elInventarioAGuardar.modelo,
				nombreDelRepuesto = elInventarioAGuardar.nombreDelRepuesto,
				vehiculo = elInventarioAGuardar.vehiculo
			};
		}
	}
}
