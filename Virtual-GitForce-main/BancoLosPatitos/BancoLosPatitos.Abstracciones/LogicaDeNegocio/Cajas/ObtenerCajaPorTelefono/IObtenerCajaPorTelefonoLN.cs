using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.ObtenerCajaPorTelefono
{
 
    public interface IObtenerCajaPorTelefonoLN
    {
       
        CajasDto Obtener(string telefono);
    }
}
