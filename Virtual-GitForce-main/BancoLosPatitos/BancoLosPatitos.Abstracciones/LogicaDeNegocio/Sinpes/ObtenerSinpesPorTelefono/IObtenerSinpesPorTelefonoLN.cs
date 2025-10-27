using BancoLosPatitos.Abstracciones.ModelosParaUI.Sinpes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.LogicaDeNegocio.Sinpes.ObtenerSinpesPorTelefono
{
   
    public interface IObtenerSinpesPorTelefonoLN
    {
       
        List<SinpeDto> Obtener(string telefono);
    }
}
