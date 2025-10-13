using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.RegistrarCliente
{
    public interface IRegistrarClienteLN
    {
        Task<int> Registrar(ClientesDto elClienteParaGuardar);
    }
}