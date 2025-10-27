using System.Threading.Tasks;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.RegistrarHabitacion
{
    public interface IRegistrarHabitacionAD
    {
        Task<int> Registrar(HabitacionesDto d);
    }
}
