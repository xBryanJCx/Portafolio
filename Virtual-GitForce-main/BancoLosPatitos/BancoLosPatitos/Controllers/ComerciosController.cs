using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.EditarComercio;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.ObtenerComercioPorId;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.ObtenerListaDeComercios;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.RegistrarComercio;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.LogicaDeNegocio.Comercios.EditarComercio;
using BancoLosPatitos.LogicaDeNegocio.Comercios.ObtenerComercioPorId;
using BancoLosPatitos.LogicaDeNegocio.Comercios.ObtenerListaDeComercios;
using BancoLosPatitos.LogicaDeNegocio.Comercios.RegistrarComercio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BancoLosPatitos.Controllers
{
    public class ComerciosController : Controller
    {

        private readonly IObtenerListaDeComerciosLN _obtenerListaDeComerciosLN;
        private readonly IRegistrarComercioLN _registrarComercioLN;
        private readonly IEditarComercioLN _editarComercioLN;
        private readonly IObtenerComercioPorIdLN _obtenerComercioPorIdLN;
        //private readonly IEliminarComercioLN _eliminarComercioLN;

        public ComerciosController()
        {
            _obtenerListaDeComerciosLN = new ObtenerListaDeComerciosLN();
            _registrarComercioLN = new RegistrarComercioLN();
            _editarComercioLN = new EditarComercioLN();
            _obtenerComercioPorIdLN = new ObtenerComercioPorIdLN();
            //_eliminarComercioLN = new EliminarComercioLN();

        }
        // GET: Comercios
        public ActionResult ListaDeComercios()
        {
            List<ComerciosDto> laListaDeComercios = _obtenerListaDeComerciosLN.Obtener();
            return View(laListaDeComercios);
        }

        // GET: Comercios/Details/5
        public ActionResult Detalles(int id)
        {
            ComerciosDto elComercio = _obtenerComercioPorIdLN.Obtener(id);
            return View(elComercio);
        }

        // GET: Comercios/Create
        public ActionResult RegistrarComercio()
        {
            return View();
        }

        // POST: Comercios/Create
        [HttpPost]
        public async Task<ActionResult> RegistrarComercio(ComerciosDto elComercioAGuardar)
        {

            try
            {
                var listaDeComercios = _obtenerListaDeComerciosLN.Obtener();
                bool existe = listaDeComercios.Any(c => c.Identificacion == elComercioAGuardar.Identificacion);

                if (existe)
                {
                    ViewBag.MensajeError = "Ya existe un comercio con este número de identificación.";
                    return View(elComercioAGuardar);
                }


                int cantidadDeDatosRegistrados = await _registrarComercioLN.Registrar(elComercioAGuardar);

                return RedirectToAction("ListaDeComercios");
            }
            catch
            {
                return View(elComercioAGuardar);
            }
        }

        // GET: Comercios/Edit/5
        public ActionResult EditarComercio(int id)
        {
            ComerciosDto elComercio = _obtenerComercioPorIdLN.Obtener(id);
            return View(elComercio);
        }

        // POST: Comercios/Edit/5
        [HttpPost]
        public ActionResult EditarComercio(int id, ComerciosDto elComercioParaActualizar)
        {
            try
            {
                // TODO: Add update logic here
                int cantidadDeDatosEditados = _editarComercioLN.Editar(elComercioParaActualizar);
                return RedirectToAction("ListaDeComercios");
            }
            catch
            {
                return View();
            }
        }

        //// GET: Comercios/Eliminar/5
        //public ActionResult EliminarComercio(int id)
        //{
        //    ComerciosDto elComercio = _obtenerComercioPorIdLN.Obtener(id);
        //    return View(elComercio);
        //}

        //// POST: Comercios/Eliminar/5
        //[HttpPost, ActionName("EliminarComercio")]
        //public ActionResult ConfirmarEliminacion(int id)
        //{
        //    try
        //    {
                
        //        var elComercio = _obtenerComercioPorIdLN.Obtener(id);

        //        if (elComercio == null)
        //        {
        //            ModelState.AddModelError("", "El comercio no existe o ya fue eliminado.");
        //            return RedirectToAction("ListaDeComercios");
        //        }

        //        elComercio.Estado = false;
        //        _editarComercioLN.Editar(elComercio);

        //        TempData["Mensaje"] = "✅ Comercio eliminado correctamente (marcado como inactivo).";
        //        return RedirectToAction("ListaDeComercios");
        //    }
        //    catch (Exception ex)
        //    {
        //        ModelState.AddModelError("", "Ocurrió un error al eliminar el comercio: " + ex.Message);
        //        return View();
        //    }
        //}

    }
}