using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.RegistrarComercio;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.RegistrarComercio;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comunes.GestorDeFechas;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.AccesoADatos.Comercios.RegistrarComercio;
using BancoLosPatitos.LogicaDeNegocio.Comunes.GestorDeFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Comercios.RegistrarComercio
{
    public class RegistrarComercioLN : IRegistrarComercioLN
    {
        private IRegistrarComercioDA _registrarComercioDA;
        private IFechaLN _fechaLN;

        public RegistrarComercioLN()
        {
            _registrarComercioDA = new RegistrarComercioDA();
            _fechaLN = new FechaLN();
        }

        public async Task<int> Registrar(ComerciosDto elComercioAGuardar)
        {

            elComercioAGuardar.FechaDeRegistro = _fechaLN.ObtenerFechaActual();
            elComercioAGuardar.FechaDeModificacion = default(DateTime); 
            elComercioAGuardar.Estado = true;
            int cantidadDeFilasAfectadas = await _registrarComercioDA.Registrar(elComercioAGuardar);
            return cantidadDeFilasAfectadas;
        }
        
    }
}

