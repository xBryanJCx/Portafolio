using System.Collections.Generic;
using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Reserva;
using BrayanJaenContreras.Abstracciones.AccesoADatos.Reserva.ObtenerListaDeHabitacionesDisponibles;
using BrayanJaenContreras.Abstracciones.ModelosParaUI.Habitaciones;

namespace BrayanJaenContreras.LogicaDeNegocio.Reserva.ObtenerListaDeHabitacionesDisponibles
{
    public class ObtenerListaDeHabitacionesDisponiblesLN : IObtenerListaDeHabitacionesDisponiblesLN
    {
        private readonly IObtenerListaDeHabitacionesDisponiblesAD _ad;

        public ObtenerListaDeHabitacionesDisponiblesLN(IObtenerListaDeHabitacionesDisponiblesAD ad)
        {
            _ad = ad;
        }

        public List<HabitacionesDto> Obtener() => _ad.Obtener();
    }
}
