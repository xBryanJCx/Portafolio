using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.ObtenerCajaPorTelefono;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Sinpes.RegistrarSinpe;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Sinpes;
using BancoLosPatitos.LogicaDeNegocio.Cajas.ObtenerCajaPorTelefono;
using BancoLosPatitos.LogicaDeNegocio.Sinpes.RegistrarSinpe;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BancoLosPatitos.Controllers
{
    public class SinpeController : Controller
    {
        private readonly IRegistrarSinpeLN _registrarSinpeLN;
        private readonly IObtenerCajaPorTelefonoLN _obtenerCajaPorTelefonoLN;

        public SinpeController()
        {
            _registrarSinpeLN = new RegistrarSinpeLN();
            _obtenerCajaPorTelefonoLN = new ObtenerCajaPorTelefonoLN();
        }

        public ActionResult RegistrarSinpe()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarSinpe(SinpeDto sinpeDto)
        {
            try
            {
                var caja = _obtenerCajaPorTelefonoLN.Obtener(sinpeDto.TelefonoDestinatario);
                if (caja == null || !caja.Estado)
                {
                    ViewBag.MensajeError = "El teléfono destinatario no está registrado o la caja está inactiva.";
                    return View(sinpeDto);
                }
                await _registrarSinpeLN.Registrar(sinpeDto);
                ViewBag.MensajeExitoso = "Pago SINPE registrado exitosamente.";
                return View();
            }
            catch
            {
                ViewBag.MensajeError = "Ocurrió un error al registrar el pago SINPE.";
                return View();
            }
        }
    }
}
