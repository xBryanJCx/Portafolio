using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.EditarComercio;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.EditarComercio;
using BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comunes.GestorDeFechas;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.AccesoADatos.Comercios.EditarComercio;
using BancoLosPatitos.LogicaDeNegocio.Comunes.GestorDeFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.LogicaDeNegocio.Comercios.EditarComercio
{
    public class EditarComercioLN : IEditarComercioLN
    {
        private IEditarComercioDA _editarComercioDA;
        private IFechaLN _fechaLN;

        public EditarComercioLN()
        {
            _editarComercioDA = new EditarComercioDA();
            _fechaLN = new FechaLN();
        }

        public int Editar(ComerciosDto elComercioParaActualizar)
        {
            elComercioParaActualizar.FechaDeModificacion = _fechaLN.ObtenerFechaActual();
            int cantidadDeDatosActualizados = _editarComercioDA.Editar(elComercioParaActualizar);
            return cantidadDeDatosActualizados;
        }
    }
}

