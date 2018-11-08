using System;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using AutoMapper;
using FluentValidation;
using FluentValidation.WebApi;
using NLog;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;

namespace MLA_task
{
    public static class InjectorConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            var container = new Container();
            container.Options.DefaultLifestyle = new AsyncScopedLifestyle();

            RegisterContainer(container);

            MapperSetup(container);
            ValidationSetup(config, container);
            LoggerSetup(container);

            container.RegisterWebApiControllers(config);
            container.Verify(VerificationOption.VerifyOnly);
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void RegisterContainer(Container container)
        {
           DependencyResolver.DependencyResolver.Resolve(container);
        }

        private static Assembly[] GetAssemblies()
        {
            return AppDomain.CurrentDomain.GetAssemblies().Where(asm =>
                asm.FullName.StartsWith("MLA_task", StringComparison.OrdinalIgnoreCase)).ToArray();
        }

        private static void MapperSetup(Container container)
        {
            Mapper.Initialize(config => config.AddProfiles(GetAssemblies()));
            Mapper.AssertConfigurationIsValid();
            var mapper = Mapper.Configuration.CreateMapper(container.GetInstance);
            container.RegisterInstance(typeof(IMapper), mapper);
        }

        private static void ValidationSetup(HttpConfiguration config, Container container)
        {
            FluentValidationModelValidatorProvider.Configure(config, provider => provider.ValidatorFactory = new SimpleInjectorFactory(container));
            AssemblyScanner.FindValidatorsInAssemblies(GetAssemblies()).ForEach(result =>
                container.Register(result.InterfaceType, result.ValidatorType));
        }

        private static void LoggerSetup(Container container)
        {
            container.RegisterInstance<ILogger>(LogManager.GetLogger("MLA_task logger"));
        }
    }

    public class SimpleInjectorFactory : IValidatorFactory
    {
        private readonly Container _container;

        public SimpleInjectorFactory(Container container)
        {
            _container = container;
        }

        public IValidator<T> GetValidator<T>()
        {
            try {
                return (IValidator<T>)_container.GetInstance(typeof(T));
            } catch (Exception) {
                return null;
            }
        }

        public IValidator GetValidator(Type type)
        {
            try {
                return (IValidator)_container.GetInstance(type);
            } catch (Exception) {
                return null;
            }
        }
    }
}