using BancoLosPatitos.Abstracciones.ModelosParaUI.Comercios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.LogicaDeNegocio.Comercios.RegistrarComercio
{
    public interface IRegistrarComercioLN
    {
        Task<int> Registrar(ComerciosDto elComercioAGuardar); 
    }
}
