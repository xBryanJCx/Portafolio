using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;
using System.Collections.Generic;

namespace MiPrimeraSolucion.Abstracciones.AccesoADatos.Clientes.ObtenerListaDeClientes
{
    public interface IObtenerListaDeClientesAD
    {
        List<ClientesDto> Obtener();
    }
}