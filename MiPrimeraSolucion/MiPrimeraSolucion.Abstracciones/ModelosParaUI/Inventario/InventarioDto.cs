using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Abstracciones.ModelosParaUI.Inventario
{
	public class InventarioDto
	{
		public int id { get; set; }
		[Display(Name = "Código del repuesto")]
		[Required]
		[MinLength(4)]
		public string codigoDelRepuesto { get; set; }
		public string nombreDelRepuesto { get; set; }
		public string marcaDelRepuesto { get; set; }
		public string vehiculo { get; set; }
		public string modelo { get; set; }
		public int anio { get; set; }
		public int cantidad { get; set; }
		public DateTime fechaDeRegistro { get; set; }
		public DateTime? fechaDeModificacion { get; set; }
		public bool estado { get; set; }
		//public int adjunto { get; set; }
	}
}
