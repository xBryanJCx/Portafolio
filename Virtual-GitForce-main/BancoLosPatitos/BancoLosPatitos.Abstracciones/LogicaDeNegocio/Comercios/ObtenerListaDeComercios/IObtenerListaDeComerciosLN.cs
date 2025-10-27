using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.ObtenerListaDeComercios
{
    public interface IObtenerListaDeComerciosLN
    {
        List<ComerciosDto> Obtener();
    }
}
