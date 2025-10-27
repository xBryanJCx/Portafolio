using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Entidades
{
    [Table("COMERCIOS")]
    public class ComerciosDA
    {
        [Key]

        [Column("IDCOMERCIO")]
        public int IdComercio { get; set; }
        [Column("IDENTIFICACION")]
        public string Identificacion { get; set; }
        [Column("TIPOIDENTIFICACION")]
        public int TipoIdentificacion { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("TIPODECOMERCIO")] 
        public int TipoDeComercio { get; set; }
        [Column("TELEFONO")]
        public string Telefono { get; set; }
        [Column("CORREOELECTRONICO")]
        public string CorreoElectronico { get; set; }
        [Column("DIRECCION")]
        public string Direccion { get; set; }
        [Column("FECHADEREGISTRO")]
        public DateTime FechaDeRegistro { get; set; }
        [Column("FECHADEMODIFICACION")]
        public DateTime? FechaDeModificacion { get; set; }
        [Column("ESTADO")]
        public bool Estado { get; set; }

    }
}
