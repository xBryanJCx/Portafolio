using System;
using System.Threading.Tasks;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.RegistrarHabitacion;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;
using BrayanJaenContreras.AccesoADatos.Entidades;

namespace BrayanJaenContreras.AccesoADatos.Habitaciones.RegistrarHabitacion
{
    public class RegistrarHabitacionAD : IRegistrarHabitacionAD
    {
        public async Task<int> Registrar(HabitacionesDto d)
        {
            using (var db = new Contexto())
            {
                var e = new HabitacionDA
                {
                    CodigoDeHabitacion = d.CodigoDeHabitacion,
                    NombreDeHabitacion = d.NombreDeHabitacion,
                    CantidadDeHuespedesPermitidos = d.CantidadDeHuespedesPermitidos,
                    CantidadDeCamas = d.CantidadDeCamas,
                    CantidadDeBanos = d.CantidadDeBanos,
                    Ubicacion = d.Ubicacion,
                    EncargadoDeLimpieza = d.EncargadoDeLimpieza,
                    TipoDeHabitacion = d.TipoDeHabitacion,
                    CostoDeLimpieza = d.CostoDeLimpieza,
                    CostoDeReserva = d.CostoDeReserva,
                    FechaDeRegistro = DateTime.Now,
                    Estado = d.Estado
                };
                db.Habitaciones.Add(e);
                return await db.SaveChangesAsync();
            }
        }
    }
}
