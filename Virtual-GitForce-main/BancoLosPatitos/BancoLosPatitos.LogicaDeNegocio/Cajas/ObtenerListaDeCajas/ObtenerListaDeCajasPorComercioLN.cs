using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.ObtenerCajasPorComercio;
using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.ObtenerListaDeComercios;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.ObtenerListaDeCajasPorComercio;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.ObtenerListaDeComercios;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.AccesoADatos.Cajas.ObtenerListaDeCajasPorNegocio;
using BancoLosPatitos.AccesoADatos.Comercios.ObtenerListaDeComercios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Cajas.ObtenerCajasPorComercio
{
    public class ObtenerListaDeCajasPorComercioLN : IObtenerListaDeCajasPorComercioLN
    {
        private readonly IObtenerListaDeCajasPorComercioDA _obtenerCajasDA;

        public ObtenerListaDeCajasPorComercioLN()
        {
            _obtenerCajasDA = new ObtenerListaDeCajasPorComercioDA();
        }

        public List<CajasDto> Obtener(int idComercio)
        {
            
            return _obtenerCajasDA.Obtener(idComercio);
        }

    }
}
