using System.Collections.Generic;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.Abstracciones.AccesoADatos.ReservaAdministrativa.ObtenerListaDeReservas
{
    public interface IObtenerListaDeReservasAD
    {
        List<ReservaAdministrativaDto> Obtener();
        List<ReservaAdministrativaDto> ObtenerPorHabitacion(int idHabitacion);
    }
}
