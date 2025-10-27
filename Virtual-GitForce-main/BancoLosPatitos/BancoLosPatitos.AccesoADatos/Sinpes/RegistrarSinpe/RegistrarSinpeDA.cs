using BancoLosPatitos.Abstracciones.AccesoADatos.Sinpes.RegistrarSinpe;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Sinpes;
using BancoLosPatitos.AccesoADatos.Entidades;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Sinpes.RegistrarSinpe
{
    /// <summary>
    /// Implementación concreta del registro de pagos SINPE en la base de datos.
    /// Realiza el mapeo del DTO hacia la entidad EF y persiste los cambios.
    /// </summary>
    public class RegistrarSinpeDA : IRegistrarSinpeDA
    {
        public async Task<int> Registrar(SinpeDto sinpe)
        {
            using (var context = new Contexto())
            {
                // Convertir el DTO a la entidad de acceso a datos.
                var entidad = new SinpesDA
                {
                    TelefonoOrigen = sinpe.TelefonoOrigen,
                    NombreOrigen = sinpe.NombreOrigen,
                    TelefonoDestinatario = sinpe.TelefonoDestinatario,
                    NombreDestinatario = sinpe.NombreDestinatario,
                    Monto = sinpe.Monto,
                    Descripcion = sinpe.Descripcion,
                    FechaDeRegistro = sinpe.FechaDeRegistro,
                    Estado = sinpe.Estado
                };
                context.Sinpes.Add(entidad);
                return await context.SaveChangesAsync();
            }
        }
    }
}
