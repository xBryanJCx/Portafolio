using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.EditarRepuesto;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerListaDeRepuestos;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.ObtenerRepuestoPorId;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Inventario.RegistrarRepuesto;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario;
using MiPrimeraSolucion.LogicaDeNegocio.Inventario.EditarRepuesto;
using MiPrimeraSolucion.LogicaDeNegocio.Inventario.ObtenerListaDeRepuestos;
using MiPrimeraSolucion.LogicaDeNegocio.Inventario.ObtenerRepuestoPorId;
using MiPrimeraSolucion.LogicaDeNegocio.Inventario.RegistrarRepuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraSolucion.UI.Controllers
{
    public class InventarioController : Controller
    {

        private readonly IObtenerListaDeRepuestosLN _obtenerListaDeRepuestosLN;
        private readonly IRegistrarRepuestoLN _registrarRepuestoLN;
        private readonly IEditarRepuestoLN _editarRepuestoLN;
        private readonly IObtenerRepuestoPorIdLN _obtenerRepuestoPorIdLN;
		public InventarioController()
        {
            _obtenerListaDeRepuestosLN = new ObtenerListaDeRepuestosLN();
            _registrarRepuestoLN = new RegistrarRepuestoLN();
			_editarRepuestoLN = new EditarRepuestoLN();
			_obtenerRepuestoPorIdLN = new ObtenerRepuestoPorIdLN();

		}
		// GET: Inventario
		public ActionResult ListaDeRepuestos()
        {
            List<InventarioDto> laListaDeInventario = _obtenerListaDeRepuestosLN.Obtener();
			return View(laListaDeInventario);
        }

        // GET: Inventario/Details/5
        public ActionResult Detalles(int id)
        {
            InventarioDto elRepuesto = _obtenerRepuestoPorIdLN.Obtener(id);
			return View(elRepuesto);
		}

        // GET: Inventario/Create
        public ActionResult AgregarRepuesto()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public async Task<ActionResult> AgregarRepuesto(InventarioDto elInventarioParaGuardar)
        {
            try
            {
                // TODO: Add insert logic here
                int cantidadDeDatosRegistrados = await _registrarRepuestoLN.Registrar(elInventarioParaGuardar);

				return RedirectToAction("ListaDeRepuestos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult EditarRepuesto(int id)
        {
			InventarioDto elRepuesto = _obtenerRepuestoPorIdLN.Obtener(id);
			return View(elRepuesto);
        }

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult EditarRepuesto(int id, InventarioDto elInventarioParaActualizar)
        {
            try
            {
                // TODO: Add update logic here
                int cantidadDeDatosEditados = _editarRepuestoLN.Editar(elInventarioParaActualizar);
				return RedirectToAction("ListaDeRepuestos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Delete/5
        public ActionResult Eliminar(int id)
        {
			InventarioDto elRepuesto = _obtenerRepuestoPorIdLN.Obtener(id);
			return View(elRepuesto);
		}

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult Eliminar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
