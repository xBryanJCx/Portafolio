using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.ObtenerCajaPorTelefono;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Cajas.ObtenerCajaPorTelefono
{
    /// <summary>
    /// Implementación concreta para obtener una caja a partir de su número de teléfono SINPE.
    /// </summary>
    public class ObtenerCajaPorTelefonoDA : IObtenerCajaPorTelefonoDA
    {
        public CajasDto Obtener(string telefono)
        {
            using (var context = new Contexto())
            {
                var caja = context.Cajas.FirstOrDefault(c => c.TelefonoSINPE == telefono);
                if (caja == null)
                {
                    return null;
                }
                return new CajasDto
                {
                    IdCaja = caja.IdCaja,
                    IdComercio = caja.IdComercio,
                    Nombre = caja.Nombre,
                    Descripcion = caja.Descripcion,
                    TelefonoSINPE = caja.TelefonoSINPE,
                    FechaDeRegistro = caja.FechaDeRegistro,
                    FechaDeModificacion = caja.FechaDeModificacion,
                    Estado = caja.Estado
                };
            }
        }
    }
}
