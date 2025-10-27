using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.ObtenerComercioPorId;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Comercios.ObtenerComercioPorId
{
    public class ObtenerComercioPorIdDA : IObtenerComercioPorIdDA
    {
        private Contexto _elContexto;
        public ObtenerComercioPorIdDA()
        {
            _elContexto = new Contexto();
        }
        public ComerciosDto Obtener(int idComercio)
        {
            ComerciosDto elComercio = (from comercio in _elContexto.Comercios
                                       where comercio.IdComercio == idComercio
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
                                           FechaDeRegistro = comercio.FechaDeRegistro,
                                           FechaDeModificacion = comercio.FechaDeModificacion,
                                           Estado = comercio.Estado,
                                       }).FirstOrDefault();

            return elComercio;

        }
    }
}
