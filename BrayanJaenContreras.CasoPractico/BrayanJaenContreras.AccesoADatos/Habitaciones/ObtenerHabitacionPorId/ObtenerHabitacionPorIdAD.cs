using System.Linq;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.ObtenerHabitacionPorId;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.AccesoADatos.Habitaciones.ObtenerHabitacionPorId
{
    public class ObtenerHabitacionPorIdAD : IObtenerHabitacionPorIdAD
    {
        public HabitacionesDto Obtener(int id)
        {
            using (var db = new Contexto())
            {
                return db.Habitaciones
                    .Where(h => h.Id == id)
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
                    })
                    .FirstOrDefault();
            }
        }
    }
}
