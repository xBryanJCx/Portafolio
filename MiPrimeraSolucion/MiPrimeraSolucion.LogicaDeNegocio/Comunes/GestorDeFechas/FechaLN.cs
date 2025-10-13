using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Comunes.GestorDeFechas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Comunes.GestorDeFechas
{
	public class FechaLN: IFechaLN
	{
		public DateTime ObtenerFechaActual()
		{
			int zonaHoraria = int.Parse(ConfigurationManager.AppSettings["zonaHoraria"]);
			return DateTime.UtcNow.AddHours(zonaHoraria);
		}
	}
}
