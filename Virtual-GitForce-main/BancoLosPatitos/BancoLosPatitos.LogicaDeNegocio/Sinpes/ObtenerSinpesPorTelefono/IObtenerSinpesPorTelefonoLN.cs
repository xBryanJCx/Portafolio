using BancoLosPatitos.Abstracciones.AccesoADatos.Sinpes.ObtenerSinpesPorTelefono;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Sinpes.ObtenerSinpesPorTelefono;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Sinpes;
using BancoLosPatitos.AccesoADatos.Sinpes.ObtenerSinpesPorTelefono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Sinpes.ObtenerSinpesPorTelefono
{
    /// <summary>
    /// Lógica de negocio para obtener los pagos SINPE asociados a un teléfono destinatario.
    /// Se encarga de abstraer la llamada a la capa de acceso a datos.
    /// </summary>
    public class ObtenerSinpesPorTelefonoLN : IObtenerSinpesPorTelefonoLN
    {
        private readonly IObtenerSinpesPorTelefonoDA _obtenerDA;

        public ObtenerSinpesPorTelefonoLN()
        {
            _obtenerDA = new ObtenerSinpesPorTelefonoDA();
        }

        public List<SinpeDto> Obtener(string telefono)
        {
            return _obtenerDA.Obtener(telefono);
        }
    }
}
