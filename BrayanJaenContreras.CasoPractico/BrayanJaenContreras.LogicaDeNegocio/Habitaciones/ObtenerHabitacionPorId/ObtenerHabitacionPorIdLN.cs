using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Habitaciones;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.ObtenerHabitacionPorId;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.LogicaDeNegocio.Habitaciones
{
    public class ObtenerHabitacionPorIdLN : IObtenerHabitacionPorIdLN
    {
        private readonly IObtenerHabitacionPorIdAD _ad;
        public ObtenerHabitacionPorIdLN(IObtenerHabitacionPorIdAD ad) { _ad = ad; }
        public HabitacionesDto Obtener(int id) => _ad.Obtener(id);
    }
}
