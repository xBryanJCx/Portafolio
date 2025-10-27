using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.RegistrarCaja;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.RegistrarCaja;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comunes.GestorDeFechas;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.AccesoADatos.Cajas.RegistrarCaja;
using BancoLosPatitos.AccesoADatos.Comercios.RegistrarComercio;
using BancoLosPatitos.LogicaDeNegocio.Comunes.GestorDeFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Cajas.RegistrarCaja
{
    public class RegistrarCajaLN : IRegistrarCajaLN
    {
        private IRegistrarCajaDA _registrarCajaDA;
        private IFechaLN _fechaLN;

        public RegistrarCajaLN()
        {
            _registrarCajaDA = new RegistrarCajaDA();
            _fechaLN = new FechaLN();
        }

        public async Task<int> Registrar(CajasDto laCajaAGuardar)
        {

            laCajaAGuardar.FechaDeRegistro = _fechaLN.ObtenerFechaActual();
            laCajaAGuardar.FechaDeModificacion = default(DateTime);
            int cantidadDeFilasAfectadas = await _registrarCajaDA.Registrar(laCajaAGuardar);
            return cantidadDeFilasAfectadas;
        }
    }
}
