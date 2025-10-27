using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.ObtenerCajasPorComercio;
using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.ObtenerListaDeComercios;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.ObtenerListaDeCajasPorComercio;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Cajas.ObtenerListaDeCajasPorNegocio
{
    public class ObtenerListaDeCajasPorComercioDA : IObtenerListaDeCajasPorComercioDA
    {
        private readonly Contexto _elContexto;

        public ObtenerListaDeCajasPorComercioDA()
        {
            _elContexto = new Contexto();
        }

        public List<CajasDto> Obtener(int idComercio)
        {
            List<CajasDto> laLista = (from Cajas in _elContexto.Cajas
                                      where Cajas.IdComercio == idComercio
                                      select new CajasDto
                                      {
                                              IdCaja = Cajas.IdCaja,
                                              IdComercio = Cajas.IdComercio,
                                              Nombre = Cajas.Nombre,
                                              Descripcion = Cajas.Descripcion,
                                              TelefonoSINPE = Cajas.TelefonoSINPE,
                                              FechaDeRegistro = Cajas.FechaDeRegistro,
                                              FechaDeModificacion = Cajas.FechaDeModificacion,
                                              Estado = Cajas.Estado,
                                              
                                          }).ToList();

            return laLista;
        }

    }
}
