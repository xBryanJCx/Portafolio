using System;
using System.Linq;
using System.Threading.Tasks;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Reserva.RegistrarReserva;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;
using BrayanJaenContreras.AccesoADatos.Entidades;

namespace BrayanJaenContreras.AccesoADatos.Reserva.RegistrarReserva
{
    public class RegistrarReservaAD : IRegistrarReservaAD
    {
        public async Task<int> Registrar(ReservaDto d)
        {
            using (var db = new Contexto())
            {
                var costo = db.Habitaciones
                              .Where(h => h.Id == d.IdHabitacion)
                              .Select(h => h.CostoDeReserva)
                              .FirstOrDefault();

                var dias = Math.Max(1, (d.FechaFinReserva - d.FechaInicioReserva).Days);
                var e = new ReservaDA
                {
                    NombreDeLaPersona = d.NombreDeLaPersona,
                    Identificacion = d.Identificacion,
                    Telefono = d.Telefono,
                    Correo = d.Correo,
                    FechaNacimiento = d.FechaNacimiento,
                    Direccion = d.Direccion,
                    MontoTotal = dias * costo,
                    FechaInicioReserva = d.FechaInicioReserva,
                    FechaFinReserva = d.FechaFinReserva,
                    FechaDeRegistro = DateTime.Now,
                    IdHabitacion = d.IdHabitacion
                };

                db.Reservas.Add(e);
                return await db.SaveChangesAsync();
            }
        }
    }
}
