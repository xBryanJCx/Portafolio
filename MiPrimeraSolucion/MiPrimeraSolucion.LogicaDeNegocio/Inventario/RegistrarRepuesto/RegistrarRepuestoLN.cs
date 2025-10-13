using MiPrimeraSolucion.Abstracciones.AccesoADatos.Inventario.RegistrarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Comunes.GestorDeFechas;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.RegistrarRepuesto;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using MiPrimeraSolucion.AccesoADatos.Inventario.RegistrarRepuesto;
using MiPrimeraSolucion.LogicaDeNegocio.Comunes.GestorDeFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Inventario.RegistrarRepuesto
{
	public class RegistrarRepuestoLN: IRegistrarRepuestoLN
	{
		private IRegistrarRepuestoAD _registrarRepuestoAD;
		private IFechaLN _fechaLN;

		public RegistrarRepuestoLN()
		{
			_registrarRepuestoAD = new RegistrarRepuestoAD();
			_fechaLN = new FechaLN();
		}

		public async Task<int> Registrar(InventarioDto elInventarioAGuardar)
		{
			elInventarioAGuardar.fechaDeRegistro = _fechaLN.ObtenerFechaActual();
			elInventarioAGuardar.fechaDeModificacion = null;
			elInventarioAGuardar.estado = true;
			//elInventarioAGuardar.nombreDelMes = ObtenerNombreDelMes(elInventarioAGuardar.fechaDeRegistro.Month);
			int cantidadDeFilasAfectadas = await _registrarRepuestoAD.Registrar(elInventarioAGuardar);
			return cantidadDeFilasAfectadas;
		}
		private string ObtenerNombreDelMes(int numeroDelMes)
		{
			string[] nombresDeLosMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
			return nombresDeLosMeses[numeroDelMes - 1];
		}
	}
}
