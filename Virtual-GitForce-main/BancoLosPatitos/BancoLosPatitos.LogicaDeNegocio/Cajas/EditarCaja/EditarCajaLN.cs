using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.EditarCaja;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comunes.GestorDeFechas;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using BancoLosPatitos.AccesoADatos.Cajas.EditarCaja;
using BancoLosPatitos.LogicaDeNegocio.Comunes.GestorDeFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Cajas.EditarCaja
{
    public class EditarCajaLN : IEditarCajaLN
    {
        private EditarCajaDA _editarCajaDA;
        private IFechaLN _fechaLN;
    
    public EditarCajaLN()
        {
            _editarCajaDA = new EditarCajaDA();
            _fechaLN = new FechaLN();
        }
        public int Editar(CajasDto laCajaParaActualizar)
        {
            laCajaParaActualizar.FechaDeModificacion = _fechaLN.ObtenerFechaActual();
            int cantidadDeDatosActualizados = _editarCajaDA.Editar(laCajaParaActualizar);
            return cantidadDeDatosActualizados;
        }

    }

}