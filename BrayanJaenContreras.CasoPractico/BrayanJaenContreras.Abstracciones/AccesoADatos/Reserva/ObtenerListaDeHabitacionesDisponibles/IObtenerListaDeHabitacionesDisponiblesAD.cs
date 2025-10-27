using System.Collections.Generic;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.Abstracciones.AccesoADatos.Reserva.ObtenerListaDeHabitacionesDisponibles
{
    public interface IObtenerListaDeHabitacionesDisponiblesAD
    {
        List<HabitacionesDto> Obtener();
    }
}
