using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrayanJaenContreras.AccesoADatos.Entidades
{
    public class ReservaDA
    {
        [Key] public int Id { get; set; }
        [MaxLength(150)] public string NombreDeLaPersona { get; set; }
        [MaxLength(30)] public string Identificacion { get; set; }
        [MaxLength(10)] public string Telefono { get; set; }
        [MaxLength(50)] public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [MaxLength(200)] public string Direccion { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaInicioReserva { get; set; }
        public DateTime FechaFinReserva { get; set; }
        public DateTime FechaDeRegistro { get; set; }

        [ForeignKey(nameof(Habitacion))] public int IdHabitacion { get; set; }
        public HabitacionDA Habitacion { get; set; }
    }
}
