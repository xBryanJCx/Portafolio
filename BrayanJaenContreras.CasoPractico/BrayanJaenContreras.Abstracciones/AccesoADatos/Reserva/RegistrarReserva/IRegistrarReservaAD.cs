using System.Threading.Tasks;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.Abstracciones.AccesoADatos.Reserva.RegistrarReserva
{
    public interface IRegistrarReservaAD
    {
        Task<int> Registrar(ReservaDto d);
    }
}
