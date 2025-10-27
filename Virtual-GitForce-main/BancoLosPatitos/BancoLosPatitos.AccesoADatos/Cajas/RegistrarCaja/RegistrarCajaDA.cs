using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.RegistrarCaja;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Cajas.RegistrarCaja
{
    public class RegistrarCajaDA : IRegistrarCajaDA
    {
        private Contexto _elContexto;

        public RegistrarCajaDA()
        {
            _elContexto = new Contexto();
        }

        public async Task<int> Registrar(CajasDto laCajaAGuardar)
        {


            bool existeTelefonoActivo = _elContexto.Set<CajasDA>() .Any(c => c.TelefonoSINPE == laCajaAGuardar.TelefonoSINPE && c.Estado == true);

            if (existeTelefonoActivo)
            {
                throw new Exception("Ya existe una caja activa con este número de teléfono SINPE.");
            }

            CajasDA cajaConvertidoEnEntidad = ConvertirObjetoAEntidad(laCajaAGuardar);
            _elContexto.Set<CajasDA>().Add(cajaConvertidoEnEntidad);
            int cantidadDeFilasAfectadas = await _elContexto.SaveChangesAsync();
            return cantidadDeFilasAfectadas;
        }

        private CajasDA ConvertirObjetoAEntidad(CajasDto laCajaAGuardar)
        {
            return new CajasDA
            {
                Nombre = laCajaAGuardar.Nombre,
                Descripcion = laCajaAGuardar.Descripcion,
                TelefonoSINPE = laCajaAGuardar.TelefonoSINPE,
                IdComercio = laCajaAGuardar.IdComercio,
                FechaDeRegistro = DateTime.Now,
                FechaDeModificacion = null,
                Estado = laCajaAGuardar.Estado,
            };
        }
    }
}
