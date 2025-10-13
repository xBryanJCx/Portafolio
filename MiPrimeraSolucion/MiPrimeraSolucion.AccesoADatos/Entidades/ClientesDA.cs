using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiPrimeraSolucion.AccesoADatos.Entidades
{
    [Table("Clientes")]
    public class ClientesDA
    {
        [Key]
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public DateTime fechaDeRegistro { get; set; }
        public DateTime? fechaDeModificacion { get; set; }
        public bool estado { get; set; }
    }
}