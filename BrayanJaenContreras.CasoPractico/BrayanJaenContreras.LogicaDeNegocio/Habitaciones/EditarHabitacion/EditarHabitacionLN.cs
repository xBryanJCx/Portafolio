using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Habitaciones;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.EditarHabitacion;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.LogicaDeNegocio.Habitaciones
{
    public class EditarHabitacionLN : IEditarHabitacionLN
    {
        private readonly IEditarHabitacionAD _ad;
        public EditarHabitacionLN(IEditarHabitacionAD ad) { _ad = ad; }
        public int Editar(HabitacionesDto d) => _ad.Editar(d);
    }
}
