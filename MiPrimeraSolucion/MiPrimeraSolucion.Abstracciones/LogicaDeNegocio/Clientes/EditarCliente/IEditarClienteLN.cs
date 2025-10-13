using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.EditarCliente
{
    public interface IEditarClienteLN
    {
        int Editar(ClientesDto elClienteParaActualizar);
    }
}