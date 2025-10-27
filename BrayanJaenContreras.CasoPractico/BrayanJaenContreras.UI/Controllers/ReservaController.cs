using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Reserva;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BrayanJaenContreras.UI.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IObtenerListaDeHabitacionesDisponiblesLN _obtenerHabitacionesDisponiblesLN;
        private readonly IRegistrarReservaLN _registrarReservaLN;
        private readonly IObtenerReservaPorCodigoLN _obtenerReservaPorCodigoLN;

        public ReservaController(
            IObtenerListaDeHabitacionesDisponiblesLN obtenerHabitacionesDisponiblesLN,
            IRegistrarReservaLN registrarReservaLN,
            IObtenerReservaPorCodigoLN obtenerReservaPorCodigoLN)
        {
            _obtenerHabitacionesDisponiblesLN = obtenerHabitacionesDisponiblesLN;
            _registrarReservaLN = registrarReservaLN;
            _obtenerReservaPorCodigoLN = obtenerReservaPorCodigoLN;
        }

        // VISTA: /Views/Reserva/Listar.cshtml  @model IEnumerable<HabitacionesDto>
        public ActionResult Listar()
        {
            var disponibles = _obtenerHabitacionesDisponiblesLN.Obtener() ?? new List<HabitacionesDto>();
            return View("Listar", disponibles);
        }

        // VISTA: /Views/Reserva/Reservar.cshtml  @model ReservaDto
        public ActionResult Reservar(int idHabitacion)
        {
            var modelo = new ReservaDto { IdHabitacion = idHabitacion };
            return View("Reservar", modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Reservar(ReservaDto modelo)
        {
            if (!ModelState.IsValid) return View("Reservar", modelo);
            await _registrarReservaLN.Registrar(modelo);
            return RedirectToAction("Listar");
        }

        // VISTA: /Views/Reserva/Detalles.cshtml  @model ReservaDto
        public ActionResult Detalles(int id)
        {
            var reserva = _obtenerReservaPorCodigoLN.Obtener(id);
            if (reserva == null)
            {
                TempData["Mensaje"] = "Estimado usuario, no se ha encontrado la reservación, favor realice una.";
                return RedirectToAction("Listar");
            }
            return View("Detalles", reserva);
        }
    }
}
