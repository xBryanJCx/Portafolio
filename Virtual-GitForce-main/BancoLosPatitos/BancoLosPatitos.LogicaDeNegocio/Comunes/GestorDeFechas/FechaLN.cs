using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comunes.GestorDeFechas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Comunes.GestorDeFechas
{
    public class FechaLN : IFechaLN
    {
        public DateTime ObtenerFechaActual()
        {
            int zonaHoraria = int.Parse(ConfigurationManager.AppSettings["ZonaHoraria"]);
            return DateTime.Now;
        }
    }
}

