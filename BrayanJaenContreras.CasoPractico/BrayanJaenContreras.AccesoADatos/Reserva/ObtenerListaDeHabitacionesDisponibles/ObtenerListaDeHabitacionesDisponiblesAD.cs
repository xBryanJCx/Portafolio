using System.Collections.Generic;
using System.Linq;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Reserva.ObtenerListaDeHabitacionesDisponibles;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.AccesoADatos.Reserva.ObtenerListaDeHabitacionesDisponibles
{
    public class ObtenerListaDeHabitacionesDisponiblesAD : IObtenerListaDeHabitacionesDisponiblesAD
    {
        public List<HabitacionesDto> Obtener()
        {
            using (var db = new Contexto())
            {
                // Criterio simple: habitaciones activas
                return db.Habitaciones
                    .Where(h => h.Estado)
                    .Select(h => new HabitacionesDto
                    {
                        Id = h.Id,
                        NombreDeHabitacion = h.NombreDeHabitacion,
                        CantidadDeHuespedesPermitidos = h.CantidadDeHuespedesPermitidos,
                        CantidadDeCamas = h.CantidadDeCamas,
                        CantidadDeBanos = h.CantidadDeBanos,
                        Ubicacion = h.Ubicacion,
                        TipoDeHabitacion = h.TipoDeHabitacion,
                        CostoDeReserva = h.CostoDeReserva,
                        Estado = h.Estado
                    }).ToList();
            }
        }
    }
}
