using BancoLosPatitos.Abstracciones.AccesoADatos.Sinpes.ObtenerSinpesPorTelefono;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Sinpes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoLosPatitos.AccesoADatos.Sinpes.ObtenerSinpesPorTelefono
{
    /// <summary>
    /// Implementación concreta encargada de recuperar los pagos SINPE asociados a un teléfono destinatario.
    /// </summary>
    public class ObtenerSinpesPorTelefonoDA : IObtenerSinpesPorTelefonoDA
    {
        public List<SinpeDto> Obtener(string telefono)
        {
            using (var context = new Contexto())
            {
                var lista = context.Sinpes
                    .Where(s => s.TelefonoDestinatario == telefono)
                    .OrderByDescending(s => s.FechaDeRegistro)
                    .Select(s => new SinpeDto
                    {
                        IdSinpe = s.IdSinpe,
                        TelefonoOrigen = s.TelefonoOrigen,
                        NombreOrigen = s.NombreOrigen,
                        TelefonoDestinatario = s.TelefonoDestinatario,
                        NombreDestinatario = s.NombreDestinatario,
                        Monto = s.Monto,
                        FechaDeRegistro = s.FechaDeRegistro,
                        Descripcion = s.Descripcion,
                        Estado = s.Estado
                    })
                    .ToList();
                return lista;
            }
        }
    }
}
