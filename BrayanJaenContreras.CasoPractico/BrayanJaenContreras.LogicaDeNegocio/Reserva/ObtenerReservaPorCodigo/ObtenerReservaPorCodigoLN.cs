using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Reserva;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Reserva.ObtenerReservaPorCodigo;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.LogicaDeNegocio.Reserva
{
    public class ObtenerReservaPorCodigoLN : IObtenerReservaPorCodigoLN
    {
        private readonly IObtenerReservaPorCodigoAD _ad;
        public ObtenerReservaPorCodigoLN(IObtenerReservaPorCodigoAD ad) { _ad = ad; }
        public ReservaDto Obtener(int idReserva) => _ad.Obtener(idReserva);
    }
}
