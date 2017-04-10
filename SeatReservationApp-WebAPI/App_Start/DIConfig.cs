using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using SeatReservationApp.Airplanes.Domain.DomainServiceImplementations;
using SeatReservationApp.Airplanes.Domain.DomainServicesContracts;
using SeatReservationApp.Airplanes.Domain.Repository;
using SeatReservationApp.Contracts.Application;
using SeatReservationApp.Impl.Application;
using SeatReservationApp.Infrastructure;
using SeatReservationApp.Infrastructure.Context;
using SeatReservationApp.Infrastructure.Repository;

namespace SeatReservationApp_WebAPI
{
    public static class DIConfig
    {
        public static void RegisterDependencies(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<SeatAssignmentApplicationService>().As<ISeatAssignmentApplicationService>();
            builder.RegisterType<AirplaneCreationApplicationService>().As<IAirplaneCreationApplicationService>();
            builder.RegisterType<AirplanePersistService>().As<IAirplanePersistService>();
            builder.RegisterType<AirplaneRepository>().As<IAirplaneRepository>();
            builder.RegisterType<AssignSeatService>().As<IAssignSeatService>();
            builder.RegisterType<AirplaneRecoverService>().As<IAirplaneRecoverService>();
            builder.RegisterType<AirplaneContext>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}