using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Entidades
{
    
    [Table("SINPE")]
    public class SinpesDA
    {
        [Key]
        [Column("IDSINPE")]
        public int IdSinpe { get; set; }

        [Column("TELEFONOORIGEN")]
        public string TelefonoOrigen { get; set; }

        [Column("NOMBREORIGEN")]
        public string NombreOrigen { get; set; }

        [Column("TELEFONODESTINATARIO")]
        public string TelefonoDestinatario { get; set; }

        [Column("NOMBREDESTINATARIO")]
        public string NombreDestinatario { get; set; }

        [Column("MONTO")]
        public decimal Monto { get; set; }

        [Column("FECHADEREGISTRO")]
        public DateTime FechaDeRegistro { get; set; }

        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }

        [Column("ESTADO")]
        public bool Estado { get; set; }
    }
}