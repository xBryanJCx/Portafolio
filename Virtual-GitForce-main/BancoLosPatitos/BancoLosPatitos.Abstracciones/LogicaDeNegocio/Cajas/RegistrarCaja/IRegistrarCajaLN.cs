using BancoLosPatitos.Abstracciones.ModelosParaUI.Cajas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoLosPatitos.Abstracciones.LogicaDeNegocio.Cajas.RegistrarCaja
{
    public interface IRegistrarCajaLN
    {
        //bool ExisteCajaActivaConTelefono(string telefonoSINPE, int idCajaAExcluir = 0);
       // bool ExisteCajaConNombreEnComercio(int idComercio, string nombre, int idCajaAExcluir = 0);
        Task<int> Registrar(CajasDto laCajaAGuardar);
    }
}
