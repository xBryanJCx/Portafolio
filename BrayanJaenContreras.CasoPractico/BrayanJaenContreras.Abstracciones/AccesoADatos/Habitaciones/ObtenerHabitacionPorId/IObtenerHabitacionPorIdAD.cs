using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.ObtenerHabitacionPorId
{
    public interface IObtenerHabitacionPorIdAD
    {
        HabitacionesDto Obtener(int id);
    }
}
