protected void Application_Start()
{
    // Otras configuraciones...
    
    // Configura el contenedor de DI
    var container = new UnityContainer();
    
    // Registra tus dependencias
    container.RegisterType<IObtenerListaDeHabitacionesLN, ObtenerListaDeHabitacionesLN>();
    container.RegisterType<IObtenerHabitacionPorIdLN, ObtenerHabitacionPorIdLN>();
    container.RegisterType<IRegistrarHabitacionLN, RegistrarHabitacionLN>();
    container.RegisterType<IEditarHabitacionLN, EditarHabitacionLN>();
    
    DependencyResolver.SetResolver(new UnityDependencyResolver(container));
}