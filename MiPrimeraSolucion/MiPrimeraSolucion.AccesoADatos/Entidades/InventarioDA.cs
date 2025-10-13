﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.AccesoADatos.Entidades
{
	[Table("INVENTARIO")]
	public class InventarioDA
	{
		[Column("ID")]
		public int id { get; set; }
		[Column("CODIGO_DEL_REPUESTO")]
		public string codigoDelRepuesto { get; set; }
		[Column("NOMBRE_DEL_REPUESTO")]
		public string nombreDelRepuesto { get; set; }
		[Column("MARCA_DEL_REPUESTO")]
		public string marcaDelRepuesto { get; set; }
		[Column("VEHICULO")]
		public string vehiculo { get; set; }
		[Column("MODELO")]
		public string modelo { get; set; }
		[Column("ANIO")]
		public int anio { get; set; }
		[Column("CANTIDAD")]
		public int cantidad { get; set; }
		[Column("FECHA_DE_REGISTRO")]
		public DateTime fechaDeRegistro { get; set; }
		[Column("FECHA_DE_MODIFICACION")]
		public DateTime? fechaDeModificacion { get; set; }
		[Column("ESTADO")]
		public bool estado { get; set; }
	}
}

