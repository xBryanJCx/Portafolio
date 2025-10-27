using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.ObtenerCajaPorTelefono;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.ObtenerCajaPorTelefono;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using BancoLosPatitos.AccesoADatos.Cajas.ObtenerCajaPorTelefono;

namespace BancoLosPatitos.LogicaDeNegocio.Cajas.ObtenerCajaPorTelefono
{
    public class ObtenerCajaPorTelefonoLN : IObtenerCajaPorTelefonoLN
    {
        private readonly IObtenerCajaPorTelefonoDA _obtenerCajaPorTelefonoDA;

        public ObtenerCajaPorTelefonoLN()
        {
            _obtenerCajaPorTelefonoDA = new ObtenerCajaPorTelefonoDA();
        }

        public CajasDto Obtener(string telefono)
        {
            return _obtenerCajaPorTelefonoDA.Obtener(telefono);
        }
    }
}