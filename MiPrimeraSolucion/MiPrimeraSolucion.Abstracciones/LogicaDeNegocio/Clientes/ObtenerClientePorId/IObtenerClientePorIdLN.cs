using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;

namespace MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.ObtenerClientePorId
{
    public interface IObtenerClientePorIdLN
    {
        ClientesDto Obtener(string id);
    }
}