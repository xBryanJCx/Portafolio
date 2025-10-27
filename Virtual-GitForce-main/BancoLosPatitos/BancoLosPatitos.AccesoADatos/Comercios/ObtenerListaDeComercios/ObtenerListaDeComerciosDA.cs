using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.ObtenerListaDeComercios;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Comercios.ObtenerListaDeComercios
{
    public class ObtenerListaDeComerciosDA : IObtenerListaDeComerciosDA
    {
        private Contexto _elContexto;


        public ObtenerListaDeComerciosDA()
        {
            _elContexto = new Contexto();
        }

        public List<ComerciosDto> Obtener()
        {
            List<ComerciosDto> laLista = (from comercio in _elContexto.Comercios
                                          select new ComerciosDto
                                          {
                                              IdComercio = comercio.IdComercio,
                                              Identificacion = comercio.Identificacion,
                                              TipoIdentificacion = comercio.TipoIdentificacion,
                                              Nombre = comercio.Nombre,
                                              TipoDeComercio = comercio.TipoDeComercio,
                                              Telefono = comercio.Telefono,
                                              CorreoElectronico = comercio.CorreoElectronico,
                                              Direccion = comercio.Direccion,
                                              Estado = comercio.Estado,
                                              FechaDeRegistro = comercio.FechaDeRegistro,
                                              FechaDeModificacion = comercio.FechaDeModificacion
                                          }).ToList();

            return laLista;
        }
    }
}
