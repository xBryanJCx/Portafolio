using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.RegistrarComercio;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Comercios.RegistrarComercio
{
    public class RegistrarComercioDA : IRegistrarComercioDA
    {
        private Contexto _elContexto;
        public RegistrarComercioDA()
        {
            _elContexto = new Contexto();
        }
        public async Task<int> Registrar(ComerciosDto elComercioAGuardar)
        {
            bool existe = _elContexto.Set<ComerciosDA>()
        .Any(c => c.Identificacion == elComercioAGuardar.Identificacion);

            if (existe)
            {
                throw new Exception("Ya existe un comercio con esta identificación");
            }

            ComerciosDA comercioConvertidoEnEntidad = ConvertirObjetoAEntidad(elComercioAGuardar);
            _elContexto.Set<ComerciosDA>().Add(comercioConvertidoEnEntidad);
            int cantidadDeFilasAfectadas = await _elContexto.SaveChangesAsync();
            return cantidadDeFilasAfectadas;
        }

        private ComerciosDA ConvertirObjetoAEntidad(ComerciosDto elComercioAGuardar)
        {
            return new ComerciosDA
            {
                Identificacion = elComercioAGuardar.Identificacion,
                TipoIdentificacion = elComercioAGuardar.TipoIdentificacion,
                Nombre = elComercioAGuardar.Nombre,
                TipoDeComercio = elComercioAGuardar.TipoDeComercio,
                Telefono = elComercioAGuardar.Telefono,
                CorreoElectronico = elComercioAGuardar.CorreoElectronico,
                Direccion = elComercioAGuardar.Direccion,
                FechaDeRegistro = DateTime.Now,
                Estado = true,
            };

        }

    }
}
