using System;
using System.ComponentModel.DataAnnotations;

namespace BrayanJaenContreras.AccesoADatos.Entidades
{
    public class HabitacionDA
    {
        [Key] public int Id { get; set; }
        [MaxLength(7)] public string CodigoDeHabitacion { get; set; }
        [MaxLength(30)] public string NombreDeHabitacion { get; set; }
        public int CantidadDeHuespedesPermitidos { get; set; }
        public int CantidadDeCamas { get; set; }
        public int CantidadDeBanos { get; set; }
        [MaxLength(10)] public string Ubicacion { get; set; }
        [MaxLength(100)] public string EncargadoDeLimpieza { get; set; }
        public int TipoDeHabitacion { get; set; }   // 1,2,3
        public decimal CostoDeLimpieza { get; set; }
        public decimal CostoDeReserva { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime? FechaDeModificacion { get; set; }
        public bool Estado { get; set; }
    }
}
