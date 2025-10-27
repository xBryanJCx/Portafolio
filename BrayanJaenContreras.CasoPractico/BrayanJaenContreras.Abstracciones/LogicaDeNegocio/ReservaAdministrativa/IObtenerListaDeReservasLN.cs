using System.Collections.Generic;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.Abstracciones.LogicaDeNegocio.ReservaAdministrativa
{
    public interface IObtenerListaDeReservasLN
    {
        List<ReservaAdministrativaDto> Obtener();
        List<ReservaAdministrativaDto> ObtenerPorHabitacion(int idHabitacion);
    }
}
