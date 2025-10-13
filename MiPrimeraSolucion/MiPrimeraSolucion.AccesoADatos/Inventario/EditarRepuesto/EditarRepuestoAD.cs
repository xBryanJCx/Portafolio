using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EditarRepuesto;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using MiPrimeraSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Inventario.EditarRepuesto
{
	public class EditarRepuestoAD: IEditarRepuestoAD
	{
		private Contexto _elContexto;
		public EditarRepuestoAD()
		{
			_elContexto = new Contexto();
		}
		public int Editar(InventarioDto elInventarioParaActualizar)
		{
			InventarioDA elInventarioEnBaseDeDatos = _elContexto.Inventarios.FirstOrDefault(inventarioABuscar => inventarioABuscar.id == elInventarioParaActualizar.id);
			if (elInventarioEnBaseDeDatos == null)
			{
				return 0;
			}
			elInventarioEnBaseDeDatos.anio = elInventarioParaActualizar.anio;
			elInventarioEnBaseDeDatos.cantidad = elInventarioParaActualizar.cantidad;
			elInventarioEnBaseDeDatos.codigoDelRepuesto = elInventarioParaActualizar.codigoDelRepuesto;
			elInventarioEnBaseDeDatos.estado = elInventarioParaActualizar.estado;
			elInventarioEnBaseDeDatos.fechaDeModificacion = elInventarioParaActualizar.fechaDeModificacion;
			elInventarioEnBaseDeDatos.modelo = elInventarioParaActualizar.modelo;
			int cantidadDeFilasAfectadas = _elContexto.SaveChanges();
			return cantidadDeFilasAfectadas;
		}
	}
}
