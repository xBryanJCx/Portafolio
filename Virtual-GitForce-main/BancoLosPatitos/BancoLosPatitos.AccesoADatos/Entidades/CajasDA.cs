using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Entidades
{

    [Table("CAJAS")]
    public class CajasDA
    {
        [Key]

        [Column("IdCaja")]
        public int IdCaja { get; set; }
        [Column("IdComercio")]
        public int IdComercio { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Column("TelefonoSINPE")]
        public string TelefonoSINPE { get; set; }
       
        [Column("FechaDeRegistro")]
        public DateTime FechaDeRegistro { get; set; }
        [Column("FechaDeModificacion")]
        public DateTime? FechaDeModificacion { get; set; }
        [Column("Estado")]
        public bool Estado { get; set; }
    }
}
