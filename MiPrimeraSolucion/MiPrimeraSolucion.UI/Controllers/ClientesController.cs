using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.EditarCliente;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.ObtenerListaDeClientes;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.ObtenerClientePorId;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.RegistrarCliente;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;
using MiPrimeraSolucion.LogicaDeNegocio.Clientes.EditarCliente;
using MiPrimeraSolucion.LogicaDeNegocio.Clientes.ObtenerListaDeClientes;
using MiPrimeraSolucion.LogicaDeNegocio.Clientes.ObtenerClientePorId;
using MiPrimeraSolucion.LogicaDeNegocio.Clientes.RegistrarCliente;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MiPrimeraSolucion.UI.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IObtenerListaDeClientesLN _obtenerListaDeClientesLN;
        private readonly IRegistrarClienteLN _registrarClienteLN;
        private readonly IEditarClienteLN _editarClienteLN;
        private readonly IObtenerClientePorIdLN _obtenerClientePorIdLN;

        public ClientesController()
        {
            _obtenerListaDeClientesLN = new ObtenerListaDeClientesLN();
            _registrarClienteLN = new RegistrarClienteLN();
            _editarClienteLN = new EditarClienteLN();
            _obtenerClientePorIdLN = new ObtenerClientePorIdLN();
        }

        // GET: Clientes
        public ActionResult ListaDeClientes()
        {
            List<ClientesDto> laListaDeClientes = _obtenerListaDeClientesLN.Obtener();
            return View(laListaDeClientes);
        }

        // GET: Clientes/Details/id
        public ActionResult Detalles(string id)
        {
            ClientesDto elCliente = _obtenerClientePorIdLN.Obtener(id);
            return View(elCliente);
        }

        // GET: Clientes/Create
        public ActionResult AgregarCliente()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public async Task<ActionResult> AgregarCliente(ClientesDto elClienteParaGuardar)
        {
            try
            {
                int cantidadDeDatosRegistrados = await _registrarClienteLN.Registrar(elClienteParaGuardar);
                return RedirectToAction("ListaDeClientes");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/id
        public ActionResult EditarCliente(string id)
        {
            ClientesDto elCliente = _obtenerClientePorIdLN.Obtener(id);
            return View(elCliente);
        }

        // POST: Clientes/Edit/id
        [HttpPost]
        public ActionResult EditarCliente(string id, ClientesDto elClienteParaActualizar)
        {
            try
            {
                int cantidadDeDatosEditados = _editarClienteLN.Editar(elClienteParaActualizar);
                return RedirectToAction("ListaDeClientes");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/id
        public ActionResult Eliminar(string id)
        {
            ClientesDto elCliente = _obtenerClientePorIdLN.Obtener(id);
            return View(elCliente);
        }

        // POST: Clientes/Delete/id
        [HttpPost]
        public ActionResult Eliminar(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                return RedirectToAction("ListaDeClientes");
            }
            catch
            {
                return View();
            }
        }
    }
}