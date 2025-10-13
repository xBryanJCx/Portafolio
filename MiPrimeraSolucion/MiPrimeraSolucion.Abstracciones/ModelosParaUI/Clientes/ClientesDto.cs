using System;
using System.ComponentModel.DataAnnotations;

namespace MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes
{
    public class ClientesDto
    {
        [Display(Name = "Identificación")]
        [Required(ErrorMessage = "La identificación es requerida")]
        public string identificacion { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "El primer apellido es requerido")]
        public string primerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string segundoApellido { get; set; }

        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El teléfono es requerido")]
        [Phone(ErrorMessage = "El formato del teléfono no es válido")]
        public string telefono { get; set; }

        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage = "El correo electrónico es requerido")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido")]
        public string correo { get; set; }

        [Display(Name = "Fecha de Registro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fechaDeRegistro { get; set; }

        [Display(Name = "Fecha de Modificación")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? fechaDeModificacion { get; set; }

        [Display(Name = "Estado")]
        public bool estado { get; set; }
    }
}