using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.EditarCliente;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;
using System;

namespace MiPrimeraSolucion.LogicaDeNegocio.Clientes.EditarCliente
{
    public class EditarClienteLN : IEditarClienteLN
    {
        public int Editar(ClientesDto elClienteParaActualizar)
        {
            // TODO: Implement actual data access logic
            elClienteParaActualizar.fechaDeModificacion = DateTime.Now;
            return 1;
        }
    }
}