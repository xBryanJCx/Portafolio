using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.RegistrarCliente;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;
using System;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.LogicaDeNegocio.Clientes.RegistrarCliente
{
    public class RegistrarClienteLN : IRegistrarClienteLN
    {
        public async Task<int> Registrar(ClientesDto elClienteParaGuardar)
        {
            // TODO: Implement actual data access logic
            elClienteParaGuardar.fechaDeRegistro = DateTime.Now;
            elClienteParaGuardar.estado = true;
            return 1;
        }
    }
}