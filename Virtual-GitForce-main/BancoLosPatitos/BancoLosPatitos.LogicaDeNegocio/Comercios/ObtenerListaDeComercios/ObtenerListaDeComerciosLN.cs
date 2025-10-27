using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.ObtenerComercioPorId;
using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.ObtenerListaDeComercios;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.ObtenerListaDeComercios;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.AccesoADatos.Comercios.ObtenerComercioPorId;
using BancoLosPatitos.AccesoADatos.Comercios.ObtenerListaDeComercios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Comercios.ObtenerListaDeComercios
{
    public class ObtenerListaDeComerciosLN : IObtenerListaDeComerciosLN
    {
        private readonly IObtenerListaDeComerciosDA _obtenerListaDeComerciosDA;
        public ObtenerListaDeComerciosLN()
        {
            _obtenerListaDeComerciosDA = new ObtenerListaDeComerciosDA();
        }
        public List<ComerciosDto> Obtener()
        {
            List<ComerciosDto> laListaDeComercios = _obtenerListaDeComerciosDA.Obtener();
            return laListaDeComercios;
        }
    }

}

