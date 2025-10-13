using System;
using System.ComponentModel.DataAnnotations;

namespace MiPrimeraSolucion.Abstracciones.ModelosParaUI.Clientes
{
    public class ClientesDto
    {
        [Display(Name = "Identificaci�n")]
        [Required(ErrorMessage = "La identificaci�n es requerida")]
        public string identificacion { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "El primer apellido es requerido")]
        public string primerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string segundoApellido { get; set; }

        [Display(Name = "Tel�fono")]
        [Required(ErrorMessage = "El tel�fono es requerido")]
        [Phone(ErrorMessage = "El formato del tel�fono no es v�lido")]
        public string telefono { get; set; }

        [Display(Name = "Correo Electr�nico")]
        [Required(ErrorMessage = "El correo electr�nico es requerido")]
        [EmailAddress(ErrorMessage = "El formato del correo electr�nico no es v�lido")]
        public string correo { get; set; }

        [Display(Name = "Fecha de Registro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fechaDeRegistro { get; set; }

        [Display(Name = "Fecha de Modificaci�n")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? fechaDeModificacion { get; set; }

        [Display(Name = "Estado")]
        public bool estado { get; set; }
    }
}