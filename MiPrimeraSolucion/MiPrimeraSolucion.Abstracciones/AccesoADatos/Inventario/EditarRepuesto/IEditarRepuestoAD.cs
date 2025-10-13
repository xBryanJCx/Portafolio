using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.EditarRepuesto
{
	public interface IEditarRepuestoAD
	{
		int Editar(InventarioDto elInventarioParaActualizar);
	}
}
