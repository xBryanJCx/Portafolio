using BancoLosPatitos.Abstracciones.AccesoADatos.Sinpes.RegistrarSinpe;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comunes.GestorDeFechas;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Sinpes.RegistrarSinpe;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Sinpes;
using BancoLosPatitos.AccesoADatos.Sinpes.RegistrarSinpe;
using BancoLosPatitos.LogicaDeNegocio.Comunes.GestorDeFechas;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Sinpes.RegistrarSinpe
{
    public class RegistrarSinpeLN : IRegistrarSinpeLN
    {
        private readonly IRegistrarSinpeDA _registrarSinpeDA;
        private readonly IFechaLN _fechaLN;

        public RegistrarSinpeLN()
        {
            _registrarSinpeDA = new RegistrarSinpeDA();
            _fechaLN = new FechaLN();
        }

        public async Task<int> Registrar(SinpeDto sinpe)
        {
            sinpe.FechaDeRegistro = _fechaLN.ObtenerFechaActual();
            sinpe.Estado = false;
            return await _registrarSinpeDA.Registrar(sinpe);
        }
    }
}