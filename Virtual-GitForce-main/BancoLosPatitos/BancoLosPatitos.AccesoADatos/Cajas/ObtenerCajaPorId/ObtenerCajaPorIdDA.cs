using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.ObterCajaPorId;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Cajas.ObtenerCajaPorId
{
    public class ObtenerCajaPorIdDA: IObtenerCajaPorIdDA
    {
        private Contexto _elContexto;

        public ObtenerCajaPorIdDA()
        {
            _elContexto = new Contexto();
        }
        public CajasDto Obtener(int idCaja)
        {
            CajasDto laCaja = (from caja in _elContexto.Cajas
                               where caja.IdCaja == idCaja
                               select new CajasDto
                               {
                                   IdCaja = caja.IdCaja,
                                   IdComercio = caja.IdComercio,
                                   Nombre = caja.Nombre,
                                   Descripcion = caja.Descripcion,
                                   TelefonoSINPE = caja.TelefonoSINPE,
                                   FechaDeRegistro = caja.FechaDeRegistro,
                                   FechaDeModificacion = caja.FechaDeModificacion,
                                   Estado = caja.Estado,
                               }).FirstOrDefault();
            return laCaja;
        }
    }
}
