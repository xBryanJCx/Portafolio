using MiPrimeraSolucion.Abstracciones.AccesoADatos.Clientes.ObtenerListaDeClientes;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;
using System.Collections.Generic;
using System.Linq;

namespace MiPrimeraSolucion.AccesoADatos.Clientes.ObtenerListaDeClientes
{
    public class ObtenerListaDeClientesAD : IObtenerListaDeClientesAD
    {
        private Contexto _elContexto;
        public ObtenerListaDeClientesAD()
        {
            _elContexto = new Contexto();
        }

        public List<ClientesDto> Obtener()
        {
            List<ClientesDto> laListaDeClientes = (from cliente in _elContexto.Clientes
                                                  select new ClientesDto
                                                  {
                                                      identificacion = cliente.identificacion,
                                                      nombre = cliente.nombre,
                                                      primerApellido = cliente.primerApellido,
                                                      segundoApellido = cliente.segundoApellido,
                                                      telefono = cliente.telefono,
                                                      correo = cliente.correo,
                                                      fechaDeRegistro = cliente.fechaDeRegistro,
                                                      fechaDeModificacion = cliente.fechaDeModificacion,
                                                      estado = cliente.estado
                                                  }).ToList();
            return laListaDeClientes;
        }
    }
}