using System.Collections.Generic;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Reserva
{
    public interface IObtenerListaDeHabitacionesDisponiblesLN
    {
        List<HabitacionesDto> Obtener();
    }
}
