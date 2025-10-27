using System.Threading.Tasks;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Reserva
{
    public interface IRegistrarReservaLN
    {
        Task<int> Registrar(ReservaDto d);
    }
}
