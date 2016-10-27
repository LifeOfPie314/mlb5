using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;

namespace Mlb5.App_Start
{
    public class AutofacConfig
    {
        public static IContainer Start()
        {

            var builder = new ContainerBuilder();

            // Automapper Registration
            builder.Register(ctx => AutoMapperConfig.Get()).As<MapperConfiguration>();
            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>();

            //builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterFilterProvider();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            // DB
            builder.RegisterType<PrototypeContext>().AsSelf();

            // MediatR
            //builder.RegisterSource(new ContravariantRegistrationSource());
            //builder.RegisterAssemblyTypes(typeof(IMediator).Assembly).AsImplementedInterfaces();
            //builder.Register<SingleInstanceFactory>(ctx =>
            //{
            //  var c = ctx.Resolve<IComponentContext>();
            //  return t => c.Resolve(t);
            //});
            //builder.Register<MultiInstanceFactory>(ctx =>
            //{
            //  var c = ctx.Resolve<IComponentContext>();
            //  return t => (IEnumerable<object>)c.Resolve(typeof(IEnumerable<>).MakeGenericType(t));
            //});


            var container = builder.Build();

            // MVC Resolver
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            // WebAPI Resolver
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
            return container;
        }
    }
}