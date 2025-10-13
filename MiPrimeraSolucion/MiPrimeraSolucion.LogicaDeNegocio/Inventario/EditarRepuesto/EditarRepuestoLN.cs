using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EditarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Comunes.GestorDeFechas;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EditarRepuesto;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using MiPrimeraSolucion.AccesoADatos.Inventario.EditarRepuesto;
using MiPrimeraSolucion.LogicaDeNegocio.Comunes.GestorDeFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.EditarRepuesto
{
	public class EditarRepuestoLN: IEditarRepuestoLN
	{
		private IEditarRepuestoAD _editarRepuestoAD;
		private IFechaLN _fechaLN;

		public EditarRepuestoLN()
		{
			_editarRepuestoAD = new EditarRepuestoAD();
			_fechaLN = new FechaLN();
		}
		
		public int Editar(InventarioDto elInventarioParaActualizar)
		{
			elInventarioParaActualizar.fechaDeModificacion = _fechaLN.ObtenerFechaActual();
			int cantidadDeDatosActualizados = _editarRepuestoAD.Editar(elInventarioParaActualizar);
			return cantidadDeDatosActualizados;
		}
	}
}
