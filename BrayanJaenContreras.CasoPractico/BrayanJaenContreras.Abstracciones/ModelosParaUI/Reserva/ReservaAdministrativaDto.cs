using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrayanJaenContreras.Abstracciones.ModelosParaUI.Reserva
{
    public class ReservaAdministrativaDto
    {
        public string NombreDePersona { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Identificacion { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaInicioReservacion { get; set; }
        public DateTime FechaFinReservacion { get; set; }
        public DateTime FechaDeRegistro { get; set; }
    }
}
