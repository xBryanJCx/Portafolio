using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.Abstracciones.AccesoADatos.Reserva.ObtenerReservaPorCodigo
{
    public interface IObtenerReservaPorCodigoAD
    {
        ReservaDto Obtener(int idReserva);
    }
}
