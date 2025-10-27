using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.ObtenerListaDeComercios
{
    public interface IObtenerListaDeComerciosDA
    {
        List<ComerciosDto> Obtener();
    }
}
