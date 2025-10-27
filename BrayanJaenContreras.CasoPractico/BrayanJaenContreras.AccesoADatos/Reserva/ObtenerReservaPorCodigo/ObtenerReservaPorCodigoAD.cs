using System.Linq;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Reserva.ObtenerReservaPorCodigo;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.AccesoADatos.Reserva.ObtenerReservaPorCodigo
{
    public class ObtenerReservaPorCodigoAD : IObtenerReservaPorCodigoAD
    {
        public ReservaDto Obterner(int idReserva) => Obtener(idReserva); // alias si tu interfaz lo pide

        public ReservaDto Obtener(int idReserva)
        {
            using (var db = new Contexto())
            {
                return db.Reservas
                    .Where(r => r.Id == idReserva)
                    .Select(r => new ReservaDto
                    {
                        Id = r.Id,
                        NombreDeLaPersona = r.NombreDeLaPersona,
                        Identificacion = r.Identificacion,
                        Telefono = r.Telefono,
                        Correo = r.Correo,
                        FechaNacimiento = r.FechaNacimiento,
                        Direccion = r.Direccion,
                        MontoTotal = r.MontoTotal,
                        FechaInicioReserva = r.FechaInicioReserva,
                        FechaFinReserva = r.FechaFinReserva,
                        FechaDeRegistro = r.FechaDeRegistro,
                        IdHabitacion = r.IdHabitacion
                    })
                    .FirstOrDefault();
            }
        }
    }
}
