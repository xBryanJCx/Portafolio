using System.Threading.Tasks;
using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Habitaciones;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Habitaciones.RegistrarHabitacion;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.LogicaDeNegocio.Habitaciones
{
    public class RegistrarHabitacionLN : IRegistrarHabitacionLN
    {
        private readonly IRegistrarHabitacionAD _ad;
        public RegistrarHabitacionLN(IRegistrarHabitacionAD ad) { _ad = ad; }
        public Task<int> Registrar(HabitacionesDto d) => _ad.Registrar(d);
    }
}
