using BancoLosPatitos.Abstracciones.AccesoADatos.Cajas.EditarCaja;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using BancoLosPatitos.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Cajas.EditarCaja
{
    public class EditarCajaDA : IEditarCaja
    {
        private Contexto _elContexto;
        public EditarCajaDA()
        {
            _elContexto = new Contexto();
        }
        public int Editar(CajasDto laCajaParaActualizar)
        {

            CajasDA laCajaEnBaseDeDatos = _elContexto.Cajas.FirstOrDefault(cajaABuscar => cajaABuscar.IdCaja== laCajaParaActualizar.IdCaja);
            if (laCajaEnBaseDeDatos == null)
            {
                return 0;
            }
            laCajaEnBaseDeDatos.IdComercio = laCajaParaActualizar.IdComercio;
            laCajaEnBaseDeDatos.IdCaja = laCajaParaActualizar.IdCaja;
            laCajaEnBaseDeDatos.Nombre = laCajaParaActualizar.Nombre;
            laCajaEnBaseDeDatos.Descripcion = laCajaParaActualizar.Descripcion;
            laCajaEnBaseDeDatos.TelefonoSINPE = laCajaParaActualizar.TelefonoSINPE;
            laCajaEnBaseDeDatos.FechaDeModificacion = DateTime.Now;
            laCajaEnBaseDeDatos.Estado = laCajaParaActualizar.Estado;

            int cantidadDeFilasAfectadas = _elContexto.SaveChanges();
            return cantidadDeFilasAfectadas;
        }
    }

}
