using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.ObtenerCajasPorComercio
{
    public interface IObtenerListaDeCajasPorComercioDA
    {
        List<CajasDto> Obtener(int idComercio);
    }
}
