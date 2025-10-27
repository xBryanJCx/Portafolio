using System.Collections.Generic;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Habitaciones
{
    public interface IObtenerListaDeHabitacionesLN
    {
        List<HabitacionesDto> Obtener();
    }
}
