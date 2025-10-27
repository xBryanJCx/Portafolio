using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Habitaciones
{
    public interface IObtenerHabitacionPorIdLN
    {
        HabitacionesDto Obtener(int id);
    }
}
