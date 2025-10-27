using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.EditarCaja
{
    public interface IEditarCajaLN
    {
        int Editar( CajasDto laCajaParaActualizar);
    }
}
