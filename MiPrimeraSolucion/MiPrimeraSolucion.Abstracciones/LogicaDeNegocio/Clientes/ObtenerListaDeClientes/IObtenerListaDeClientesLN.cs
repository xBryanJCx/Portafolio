using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;
using System.Collections.Generic;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.ObtenerListaDeClientes
{
    public interface IObtenerListaDeClientesLN
    {
        List<ClientesDto> Obtener();
    }
}