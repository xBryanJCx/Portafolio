using System.Collections.Generic;
using System.Linq;
using BrayanJaenContreras.Abstracciones.AccesoADatos.ReservaAdministrativa.ObtenerListaDeReservas;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva;

namespace BrayanJaenContreras.AccesoADatos.ReservaAdministrativa.ObtenerListaDeReservas
{
    public class ObtenerListaDeReservasAD : IObtenerListaDeReservasAD
    {
        public List<ReservaAdministrativaDto> Obtener()
        {
            using (var db = new Contexto())
            {
                return db.Reservas
                    .Select(r => new ReservaAdministrativaDto
                    {
                        NombreDePersona = r.NombreDeLaPersona,
                        Telefono = r.Telefono,
                        Correo = r.Correo,
                        Identificacion = r.Identificacion,
                        MontoTotal = r.MontoTotal,
                        FechaNacimiento = r.FechaNacimiento,
                        FechaInicioReservacion = r.FechaInicioReserva,
                        FechaFinReservacion = r.FechaFinReserva,
                        FechaDeRegistro = r.FechaDeRegistro
                    }).ToList();
            }
        }

        public List<ReservaAdministrativaDto> ObtenerPorHabitacion(int idHabitacion)
        {
            using (var db = new Contexto())
            {
                return db.Reservas
                    .Where(r => r.IdHabitacion == idHabitacion)
                    .Select(r => new ReservaAdministrativaDto
                    {
                        NombreDePersona = r.NombreDeLaPersona,
                        Telefono = r.Telefono,
                        Correo = r.Correo,
                        Identificacion = r.Identificacion,
                        MontoTotal = r.MontoTotal,
                        FechaNacimiento = r.FechaNacimiento,
                        FechaInicioReservacion = r.FechaInicioReserva,
                        FechaFinReservacion = r.FechaFinReserva,
                        FechaDeRegistro = r.FechaDeRegistro
                    }).ToList();
            }
        }
    }
}
