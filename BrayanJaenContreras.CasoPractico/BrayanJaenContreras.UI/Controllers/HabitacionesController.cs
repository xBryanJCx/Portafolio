using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Habitaciones;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.UI.Controllers
{
    public class HabitacionesController : Controller
    {
        private readonly IObtenerListaDeHabitacionesLN _obtenerListaDeHabitacionesLN;
        private readonly IObtenerHabitacionPorIdLN _obtenerHabitacionPorIdLN;
        private readonly IRegistrarHabitacionLN _registrarHabitacionLN;
        private readonly IEditarHabitacionLN _editarHabitacionLN;

        public HabitacionesController(
            IObtenerListaDeHabitacionesLN obtenerListaDeHabitacionesLN,
            IObtenerHabitacionPorIdLN obtenerHabitacionPorIdLN,
            IRegistrarHabitacionLN registrarHabitacionLN,
            IEditarHabitacionLN editarHabitacionLN)
        {
            _obtenerListaDeHabitacionesLN = obtenerListaDeHabitacionesLN ?? throw new ArgumentNullException(nameof(obtenerListaDeHabitacionesLN));
            _obtenerHabitacionPorIdLN = obtenerHabitacionPorIdLN ?? throw new ArgumentNullException(nameof(obtenerHabitacionPorIdLN));
            _registrarHabitacionLN = registrarHabitacionLN ?? throw new ArgumentNullException(nameof(registrarHabitacionLN));
            _editarHabitacionLN = editarHabitacionLN ?? throw new ArgumentNullException(nameof(editarHabitacionLN));
        }

        public ActionResult Index() => RedirectToAction("ListaDeHabitaciones");

        // VISTA: /Views/Habitaciones/Listar.cshtml  @model IEnumerable<HabitacionesDto>
        public ActionResult ListaDeHabitaciones()
        {
            var lista = _obtenerListaDeHabitacionesLN.Obtener() ?? new List<HabitacionesDto>();
            return View("Listar", lista);
        }

        // VISTA: /Views/Habitaciones/AgregarHabitacion.cshtml  @model HabitacionesDto
        public ActionResult AgregarHabitacion()
        {
            return View("AgregarHabitacion", new HabitacionesDto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AgregarHabitacion(HabitacionesDto modelo)
        {
            if (!ModelState.IsValid) return View("AgregarHabitacion", modelo);
            await _registrarHabitacionLN.Registrar(modelo);
            return RedirectToAction("ListaDeHabitaciones");
        }

        // VISTA: /Views/Habitaciones/EditarHabitacion.cshtml  @model HabitacionesDto
        public ActionResult EditarHabitacion(int id)
        {
            var hab = _obtenerHabitacionPorIdLN.Obtener(id);
            if (hab == null) return RedirectToAction("ListaDeHabitaciones");
            return View("EditarHabitacion", hab);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarHabitacion(int id, HabitacionesDto modelo)
        {
            if (!ModelState.IsValid) return View("EditarHabitacion", modelo);
            _editarHabitacionLN.Editar(modelo);
            return RedirectToAction("ListaDeHabitaciones");
        }

        // Enlaces desde la lista
        public ActionResult VerReservas(int id)
        {
            return RedirectToAction("Listar", "ReservaAdministrativa", new { idHabitacion = id });
        }
    }
}
