using System.Threading.Tasks;
using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Reserva;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Reserva.RegistrarReserva;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.LogicaDeNegocio.Reserva
{
    public class RegistrarReservaLN : IRegistrarReservaLN
    {
        private readonly IRegistrarReservaAD _ad;
        public RegistrarReservaLN(IRegistrarReservaAD ad) { _ad = ad; }
        public Task<int> Registrar(ReservaDto d) => _ad.Registrar(d);
    }
}
