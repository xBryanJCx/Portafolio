using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.ObtenerCajaPorTelefono
{
   public interface IObtenerCajaPorTelefonoDA
    {
       CajasDto Obtener(string telefono);
    }
}
