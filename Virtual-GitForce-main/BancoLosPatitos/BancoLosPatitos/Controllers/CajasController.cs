using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.RegistrarCaja;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.EditarCaja;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.ObtenerCajaPorId;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.ObtenerListaDeCajasPorComercio;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.RegistrarCaja;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.ObtenerComercioPorId;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.LogicaDeNegocio.Cajas.EditarCaja;
using BancoLosPatitos.LogicaDeNegocio.Cajas.ObtenerCajaPorId;
using BancoLosPatitos.LogicaDeNegocio.Cajas.ObtenerCajasPorComercio;
using BancoLosPatitos.LogicaDeNegocio.Cajas.RegistrarCaja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BancoLosPatitos.Controllers
{

    public class CajasController : Controller
    {

        private readonly IRegistrarCajaLN _registrarCajaLN;
        private readonly IObtenerListaDeCajasPorComercioLN _obtenerListaDeCajasPorComercioLN;
        private readonly IEditarCajaLN _editarCajaLN;
        private readonly IObtenerCajaPorIdLN _obtenerCajaPorIdLN;

        private readonly IObtenerComercioPorIdLN _obtenerComercioPorIdLN;


        public CajasController()
        {
            _registrarCajaLN = new RegistrarCajaLN();
            _obtenerListaDeCajasPorComercioLN = new ObtenerListaDeCajasPorComercioLN();
            _editarCajaLN = new EditarCajaLN();
            _obtenerCajaPorIdLN = new ObtenerCajaPorIdLN();
        }


        // GET: Cajas
        public ActionResult ListaDeCajasPorComercio(int idComercio)
        {

            List<CajasDto> laListaDeCajas = _obtenerListaDeCajasPorComercioLN.Obtener( idComercio);
            return View(laListaDeCajas);

        }

        // GET: Cajas/Details/5
        public ActionResult Detalles(int id)
        {
            return View();
        }

        // GET: Cajas/Create
        public ActionResult RegistrarCaja()
        {
            return View();
        }

        // POST: Cajas/Create
        [HttpPost]
        public async Task<ActionResult> RegistrarCaja( CajasDto laCajaAGuardar)
        {
            try
            {

                var listaDeCajas = _obtenerListaDeCajasPorComercioLN.Obtener(laCajaAGuardar.IdComercio);
                bool existeTelefonoActivo = listaDeCajas.Any(c => c.TelefonoSINPE == laCajaAGuardar.TelefonoSINPE && c.Estado == true);
                bool existe = listaDeCajas.Any(c => c.IdComercio == laCajaAGuardar.IdComercio && c.Nombre == laCajaAGuardar.Nombre);

                if (existe)
                {
                    ViewBag.MensajeError = "Ya existe una caja con este nombre en el comercio.";
                    return View(laCajaAGuardar);

                }
                if (existeTelefonoActivo)
                {
                    ViewBag.MensajeError = "Ya existe una caja activa con este número de teléfono SINPE.";
                    return View(laCajaAGuardar);
                }


                int cantidadDeDatosRegistrados = await _registrarCajaLN.Registrar(laCajaAGuardar);

                return RedirectToAction("ListaDeCajasPorComercio", new { idComercio = laCajaAGuardar.IdComercio });
            }
            catch
            {
                return View();
            }
        }

        // GET: Cajas/Edit/5
       public ActionResult EditarCaja(int id)
        {

            CajasDto laCaja = _obtenerCajaPorIdLN.Obtener(id);
            return View(laCaja);
        }

        // POST: Cajas/Edit/5
        [HttpPost]
        public ActionResult EditarCaja(int id, CajasDto laCajaParaActualizar)
        {
            try
            {
                int cantidadDeDatosEditados = _editarCajaLN.Editar(laCajaParaActualizar);
                return RedirectToAction("ListaDeCajasPorComercio", new { idComercio = laCajaParaActualizar.IdComercio });
            }
            catch
            {
                return View();
            }
        }

        // GET: Cajas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cajas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
