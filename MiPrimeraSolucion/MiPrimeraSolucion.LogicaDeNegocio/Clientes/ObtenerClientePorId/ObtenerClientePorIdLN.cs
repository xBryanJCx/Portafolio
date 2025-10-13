using MiPrimeraSolucion.Abstracciones.LogicaDeNegocio.Clientes.ObtenerClientePorId;
using MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes;
using System;

namespace MiPrimeraSolucion.LogicaDeNegocio.Clientes.ObtenerClientePorId
{
    public class ObtenerClientePorIdLN : IObtenerClientePorIdLN
    {
        public ClientesDto Obtener(string id)
        {
            // TODO: Implement actual data access logic
            return new ClientesDto
            {
                identificacion = id,
                nombre = "Juan",
                primerApellido = "Pérez",
                segundoApellido = "González",
                telefono = "8888-8888",
                correo = "juan@email.com",
                fechaDeRegistro = DateTime.Now,
                estado = true
            };
        }
    }
}