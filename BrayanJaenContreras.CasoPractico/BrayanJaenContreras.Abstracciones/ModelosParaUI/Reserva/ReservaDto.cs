using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva
{
    public class ReservaDto
    {
        public int Id { get; set; }
        public string NombreDeLaPersona { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaInicioReserva { get; set; }
        public DateTime FechaFinReserva { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public int IdHabitacion { get; set; }
    }
}
