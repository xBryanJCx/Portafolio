using System.Collections.Generic;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.ObtenerListaDeHabitaciones
{
    public interface IObtenerListaDeHabitacionesAD
    {
        List<HabitacionesDto> Obtener();
    }
}
