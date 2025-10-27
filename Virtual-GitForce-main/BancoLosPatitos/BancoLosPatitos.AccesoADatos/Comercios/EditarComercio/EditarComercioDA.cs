using BancoLosPatitos.Abstracciones.AccesoADatos.Comercios.EditarComercio;
using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using BancoLosPatitos.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.AccesoADatos.Comercios.EditarComercio
{
    public class EditarComercioDA : IEditarComercioDA
    {
        private Contexto _elContexto;

        public EditarComercioDA()
        {
            _elContexto = new Contexto();
        }

        public int Editar(ComerciosDto elComercioParaActualizar)
        {
            ComerciosDA elComercioEnBaseDeDatos = _elContexto.Comercios.FirstOrDefault(comercioABuscar => comercioABuscar.IdComercio == elComercioParaActualizar.IdComercio);
            if (elComercioEnBaseDeDatos == null)
            {
                return 0;
            }
            elComercioEnBaseDeDatos.Nombre = elComercioParaActualizar.Nombre;
            elComercioEnBaseDeDatos.TipoDeComercio = elComercioParaActualizar.TipoDeComercio;
            elComercioEnBaseDeDatos.Telefono = elComercioParaActualizar.Telefono;
            elComercioEnBaseDeDatos.CorreoElectronico = elComercioParaActualizar.CorreoElectronico;
            elComercioEnBaseDeDatos.Direccion = elComercioParaActualizar.Direccion;
            elComercioEnBaseDeDatos.FechaDeModificacion = DateTime.Now;
            elComercioEnBaseDeDatos.Estado = elComercioParaActualizar.Estado;
            int cantidadDeFilasAfectadas = _elContexto.SaveChanges();
            return cantidadDeFilasAfectadas;
            ;
        }
    }
}
