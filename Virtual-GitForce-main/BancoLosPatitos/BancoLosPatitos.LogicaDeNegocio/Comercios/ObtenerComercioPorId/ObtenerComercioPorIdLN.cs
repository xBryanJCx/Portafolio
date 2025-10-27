using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.ObtenerComercioPorId;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.ObtenerComercioPorId;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.AccesoADatos.Comercios.ObtenerComercioPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Comercios.ObtenerComercioPorId
{
    public class ObtenerComercioPorIdLN : IObtenerComercioPorIdLN
    {
        private IObtenerComercioPorIdDA _obtenerComercioPorIdDA;

        public ObtenerComercioPorIdLN()
        {
            _obtenerComercioPorIdDA = new ObtenerComercioPorIdDA();
        }

        public ComerciosDto Obtener(int IdComercio)
        {
            return _obtenerComercioPorIdDA.Obtener(IdComercio);
        }
    }
}
