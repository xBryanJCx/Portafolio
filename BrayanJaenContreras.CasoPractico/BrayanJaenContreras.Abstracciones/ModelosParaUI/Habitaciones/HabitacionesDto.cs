using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones
{
    public class HabitacionesDto
    {
        public int Id { get; set; }

        [Display(Name = "Código de habitación")]
        [Required]
        [StringLength(7, MinimumLength = 4)]      
        public string CodigoDeHabitacion { get; set; }
        public string NombreDeHabitacion { get; set; }
        public int CantidadDeHuespedesPermitidos { get; set; }
        public int CantidadDeCamas { get; set; }
        public int CantidadDeBanos { get; set; }
        public string Ubicacion { get; set; }
        public string EncargadoDeLimpieza { get; set; }
        public int TipoDeHabitacion { get; set; } // 1=Junior, 2=Superior, 3=Suite
        public decimal CostoDeLimpieza { get; set; }
        public decimal CostoDeReserva { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime? FechaDeModificacion { get; set; }
        public bool Estado { get; set; }
    }
}
