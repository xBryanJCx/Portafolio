using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.ModelosParaUI.Sinpes
{
    public class SinpeDto
    {
        public int IdSinpe { get; set; }
        public string TelefonoOrigen { get; set; }
        public string NombreOrigen { get; set; }
        public string TelefonoDestinatario { get; set; }
        public string NombreDestinatario { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
