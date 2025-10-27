using System.Collections.Generic;
using System.Linq;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.ObtenerListaDeHabitaciones;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.AccesoADatos.Habitaciones.ObtenerListaDeHabitaciones
{
    public class ObtenerListaDeHabitacionesAD : IObtenerListaDeHabitacionesAD
    {
        public List<HabitacionesDto> Obtener()
        {
            using (var db = new Contexto())
            {
                return db.Habitaciones
                    .Select(h => new HabitacionesDto
                    {
                        Id = h.Id,
                        CodigoDeHabitacion = h.CodigoDeHabitacion,
                        NombreDeHabitacion = h.NombreDeHabitacion,
                        CantidadDeHuespedesPermitidos = h.CantidadDeHuespedesPermitidos,
                        CantidadDeCamas = h.CantidadDeCamas,
                        CantidadDeBanos = h.CantidadDeBanos,
                        Ubicacion = h.Ubicacion,
                        EncargadoDeLimpieza = h.EncargadoDeLimpieza,
                        TipoDeHabitacion = h.TipoDeHabitacion,
                        CostoDeLimpieza = h.CostoDeLimpieza,
                        CostoDeReserva = h.CostoDeReserva,
                        FechaDeRegistro = h.FechaDeRegistro,
                        FechaDeModificacion = h.FechaDeModificacion,
                        Estado = h.Estado
                    }).ToList();
            }
        }
    }
}
