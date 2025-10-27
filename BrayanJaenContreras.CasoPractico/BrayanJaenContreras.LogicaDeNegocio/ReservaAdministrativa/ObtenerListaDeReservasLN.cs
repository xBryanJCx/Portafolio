using System.Collections.Generic;
using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.ReservaAdministrativa;
using BrayanJaenContreras.Abstracciones.AccesoADatos.ReservaAdministrativa.ObtenerListaDeReservas;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.LogicaDeNegocio.ReservaAdministrativa
{
    public class ObtenerListaDeReservasLN : IObtenerListaDeReservasLN
    {
        private readonly IObtenerListaDeReservasAD _ad;
        public ObtenerListaDeReservasLN(IObtenerListaDeReservasAD ad) { _ad = ad; }

        public List<ReservaAdministrativaDto> Obtener() => _ad.Obtener();

        public List<ReservaAdministrativaDto> ObtenerPorHabitacion(int idHabitacion)
            => _ad.ObtenerPorHabitacion(idHabitacion);
    }
}
