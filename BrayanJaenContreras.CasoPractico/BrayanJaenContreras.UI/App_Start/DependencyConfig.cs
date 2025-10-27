using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Reserva;
using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.Habitaciones;
using BrayanJaenContreras.Abstracciones.LogicaDeNegocio.ReservaAdministrativa;
using BrayanJaenContreras.UI.Controllers;

namespace BrayanJaenContreras.UI.App_Start
{
    public static class DependencyConfig
    {
        public static void RegisterDependencies()
        {
            DependencyResolver.SetResolver(new SimpleResolver());
        }

        private class SimpleResolver : IDependencyResolver
        {
            private readonly Dictionary<Type, Func<object>> _typeMap;

            public SimpleResolver()
            {
                _typeMap = new Dictionary<Type, Func<object>>
                {
                    // Controllers
                    {
                        typeof(HabitacionesController),
                        () => new HabitacionesController(
                            (IObtenerListaDeHabitacionesLN)GetService(typeof(IObtenerListaDeHabitacionesLN)),
                            (IObtenerHabitacionPorIdLN)GetService(typeof(IObtenerHabitacionPorIdLN)),
                            (IRegistrarHabitacionLN)GetService(typeof(IRegistrarHabitacionLN)),
                            (IEditarHabitacionLN)GetService(typeof(IEditarHabitacionLN))
                        )
                    },
                    {
                        typeof(ReservaController),
                        () => new ReservaController(
                            (IObtenerListaDeHabitacionesDisponiblesLN)GetService(typeof(IObtenerListaDeHabitacionesDisponiblesLN)),
                            (IRegistrarReservaLN)GetService(typeof(IRegistrarReservaLN)),
                            (IObtenerReservaPorCodigoLN)GetService(typeof(IObtenerReservaPorCodigoLN))
                        )
                    },
                    {
                        typeof(ReservaAdministrativaController),
                        () => new ReservaAdministrativaController(
                            (IObtenerListaDeReservasLN)GetService(typeof(IObtenerListaDeReservasLN))
                        )
                    },

                    // Habitaciones Services
                    {
                        typeof(IObtenerListaDeHabitacionesLN),
                        () => CreateInstance("BrayanJaenContreras.LogicaDeNegocio.Habitaciones.ObtenerListaDeHabitaciones.ObtenerListaDeHabitacionesLN",
                               CreateInstance("BrayanJaenContreras.AccesoADatos.Habitaciones.ObtenerListaDeHabitaciones.ObtenerListaDeHabitacionesAD"))
                    },
                    {
                        typeof(IRegistrarHabitacionLN),
                        () => CreateInstance("BrayanJaenContreras.LogicaDeNegocio.Habitaciones.RegistrarHabitacion.RegistrarHabitacionLN",
                               CreateInstance("BrayanJaenContreras.AccesoADatos.Habitaciones.RegistrarHabitacion.RegistrarHabitacionAD"))
                    },
                    {
                        typeof(IEditarHabitacionLN),
                        () => CreateInstance("BrayanJaenContreras.LogicaDeNegocio.Habitaciones.EditarHabitacion.EditarHabitacionLN",
                               CreateInstance("BrayanJaenContreras.AccesoADatos.Habitaciones.EditarHabitacion.EditarHabitacionAD"))
                    },
                    {
                        typeof(IObtenerHabitacionPorIdLN),
                        () => CreateInstance("BrayanJaenContreras.LogicaDeNegocio.Habitaciones.ObtenerHabitacionPorId.ObtenerHabitacionPorIdLN",
                               CreateInstance("BrayanJaenContreras.AccesoADatos.Habitaciones.ObtenerHabitacionPorId.ObtenerHabitacionPorIdAD"))
                    },

                    // Reserva Services
                    {
                        typeof(IObtenerListaDeHabitacionesDisponiblesLN),
                        () => CreateInstance("BrayanJaenContreras.LogicaDeNegocio.Reserva.ObtenerListaDeHabitacionesDisponibles.ObtenerListaDeHabitacionesDisponiblesLN",
                               CreateInstance("BrayanJaenContreras.AccesoADatos.Reserva.ObtenerListaDeHabitacionesDisponibles.ObtenerListaDeHabitacionesDisponiblesAD"))
                    },
                    {
                        typeof(IRegistrarReservaLN),
                        () => CreateInstance("BrayanJaenContreras.LogicaDeNegocio.Reserva.RegistrarReserva.RegistrarReservaLN",
                               CreateInstance("BrayanJaenContreras.AccesoADatos.Reserva.RegistrarReserva.RegistrarReservaAD"))
                    },
                    {
                        typeof(IObtenerReservaPorCodigoLN),
                        () => CreateInstance("BrayanJaenContreras.LogicaDeNegocio.Reserva.ObtenerReservaPorCodigo.ObtenerReservaPorCodigoLN",
                               CreateInstance("BrayanJaenContreras.AccesoADatos.Reserva.ObtenerReservaPorCodigo.ObtenerReservaPorCodigoAD"))
                    },

                    // ReservaAdministrativa Services
                    {
                        typeof(IObtenerListaDeReservasLN),
                        () => CreateInstance("BrayanJaenContreras.LogicaDeNegocio.ReservaAdministrativa.ObtenerListaDeReservasLN",
                               CreateInstance("BrayanJaenContreras.AccesoADatos.ReservaAdministrativa.ObtenerListaDeReservas.ObtenerListaDeReservasAD"))
                    }
                };
            }

            public object GetService(Type serviceType)
            {
                try
                {
                    if (_typeMap.TryGetValue(serviceType, out var factory))
                    {
                        var instance = factory();
                        if (instance == null)
                            throw new InvalidOperationException($"Failed to create instance of {serviceType.FullName}");
                        return instance;
                    }

                    if (typeof(Controller).IsAssignableFrom(serviceType) && serviceType.IsClass)
                    {
                        return Activator.CreateInstance(serviceType);
                    }

                    return null;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error in GetService for {serviceType.FullName}: {ex.Message}");
                    throw;
                }
            }

            public IEnumerable<object> GetServices(Type serviceType)
            {
                var service = GetService(serviceType);
                return service == null ? new object[0] : new[] { service };
            }

            private static object CreateInstance(string typeName, object argument = null)
            {
                try
                {
                    var type = Type.GetType(typeName + ", " + typeName.Split('.')[0] + "." + typeName.Split('.')[1]);
                    if (type == null)
                        throw new InvalidOperationException($"Type not found: {typeName}");

                    var instance = argument == null
                        ? Activator.CreateInstance(type)
                        : Activator.CreateInstance(type, argument);

                    if (instance == null)
                        throw new InvalidOperationException($"Failed to create instance of {typeName}");

                    return instance;
                }
                catch (Exception ex)
                {
                    var errorMessage = $"Error creating instance of {typeName}: {ex.Message}";
                    System.Diagnostics.Debug.WriteLine(errorMessage);
                    throw new InvalidOperationException(errorMessage, ex);
                }
            }
        }
    }
}
