using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Reserva
{
    public interface IObtenerReservaPorCodigoLN
    {
        ReservaDto Obtener(int idReserva);
    }
}
