using MiPrimeraSolucion.Abstracciones.AccesoADatos.Clientes.ObtenerListaDeClientes;
using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.ObtenerListaDeClientes;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;
using MiPrimeraSolucion.AccesoADatos.Clientes.ObtenerListaDeClientes;
using System.Collections.Generic;

namespace MiPrimeraSolucion.LogicaDeNegocio.Clientes.ObtenerListaDeClientes
{
    public class ObtenerListaDeClientesLN : IObtenerListaDeClientesLN
    {
        private readonly IObtenerListaDeClientesAD _obtenerListaDeClientesAD;
        
        public ObtenerListaDeClientesLN()
        {
            _obtenerListaDeClientesAD = new ObtenerListaDeClientesAD();
        }

        public List<ClientesDto> Obtener()
        {
            return _obtenerListaDeClientesAD.Obtener();
        }
    }
}