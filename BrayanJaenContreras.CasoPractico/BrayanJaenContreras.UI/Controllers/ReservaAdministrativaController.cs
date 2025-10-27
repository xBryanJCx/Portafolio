using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.ReservaAdministrativa;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BrayanJaenContreras.UI.Controllers
{
    public class ReservaAdministrativaController : Controller
    {
        private readonly IObtenerListaDeReservasLN _obtenerListaDeReservasLN;

        public ReservaAdministrativaController(IObtenerListaDeReservasLN obtenerListaDeReservasLN)
        {
            _obtenerListaDeReservasLN = obtenerListaDeReservasLN;
        }

        // VISTA: /Views/ReservaAdministrativa/Listar.cshtml  @model IEnumerable<ReservaAdministrativaDto>
        public ActionResult Listar(int? idHabitacion)
        {
            List<ReservaAdministrativaDto> lista = idHabitacion.HasValue
                ? _obtenerListaDeReservasLN.ObtenerPorHabitacion(idHabitacion.Value)
                : _obtenerListaDeReservasLN.Obtener();

            return View("Listar", lista ?? new List<ReservaAdministrativaDto>());
        }
    }
}
