using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.ObterCajaPorId;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.ObtenerCajaPorId;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using BancoLosPatitos.AccesoADatos.Cajas.ObtenerCajaPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Cajas.ObtenerCajaPorId
{
    public class ObtenerCajaPorIdLN: IObtenerCajaPorIdLN
    {
        private IObtenerCajaPorIdDA _obtenerCajaPorIdDA;

        public ObtenerCajaPorIdLN()
        {
            _obtenerCajaPorIdDA = new ObtenerCajaPorIdDA();
        }
        public CajasDto Obtener(int IdCaja)
        {
            return _obtenerCajaPorIdDA.Obtener(IdCaja);
        }
    }
}
