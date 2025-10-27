using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas
{
    public class CajasDto
    {
        public int IdCaja { get; set; }
        public int IdComercio { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Telefono de SINPE")]
        public string TelefonoSINPE { get; set; }
        [Display(Name = "Fecha De Registro")]
        public DateTime FechaDeRegistro { get; set; }
        [Display(Name = "Fecha De Modificacion")]
        public DateTime? FechaDeModificacion { get; set; }
        public bool Estado { get; set; }

    }
}