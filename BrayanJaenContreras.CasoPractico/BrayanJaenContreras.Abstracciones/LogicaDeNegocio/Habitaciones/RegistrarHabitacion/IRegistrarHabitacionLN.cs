using System.Threading.Tasks;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Habitaciones
{
    public interface IRegistrarHabitacionLN
    {
        Task<int> Registrar(HabitacionesDto d);
    }
}
