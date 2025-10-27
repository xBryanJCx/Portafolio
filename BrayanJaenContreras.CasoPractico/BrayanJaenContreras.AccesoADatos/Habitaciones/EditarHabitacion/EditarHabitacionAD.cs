using System;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.EditarHabitacion;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.AccesoADatos.Habitaciones.EditarHabitacion
{
    public class EditarHabitacionAD : IEditarHabitacionAD
    {
        public int Editar(HabitacionesDto d)
        {
            using (var db = new Contexto())
            {
                var e = db.Habitaciones.Find(d.Id);
                if (e == null) return 0;

                e.CodigoDeHabitacion = d.CodigoDeHabitacion;
                e.NombreDeHabitacion = d.NombreDeHabitacion;
                e.CantidadDeHuespedesPermitidos = d.CantidadDeHuespedesPermitidos;
                e.CantidadDeCamas = d.CantidadDeCamas;
                e.CantidadDeBanos = d.CantidadDeBanos;
                e.Ubicacion = d.Ubicacion;
                e.EncargadoDeLimpieza = d.EncargadoDeLimpieza;
                e.TipoDeHabitacion = d.TipoDeHabitacion;
                e.CostoDeLimpieza = d.CostoDeLimpieza;
                e.CostoDeReserva = d.CostoDeReserva;
                e.Estado = d.Estado;
                e.FechaDeModificacion = DateTime.Now;

                return db.SaveChanges();
            }
        }
    }
}
