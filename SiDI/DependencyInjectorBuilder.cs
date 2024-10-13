namespace SiDI
{
	public class DependencyInjectorBuilder : IDependencyInjectorBuilder
	{
		private readonly IDependencyCollection _dependencyCollection = new DependencyCollection();

		public IDependencyInjectorBuilder RegisterTransient<TInterface, TImplementation>()
			where TInterface : class?
			where TImplementation : class?, TInterface
		{
			Register<TInterface?, TImplementation>();
			return this;
		}

		public IDependencyInjectorBuilder RegisterSingleton<TInterface, TImplementation>()
			where TInterface : class?
			where TImplementation : class?, TInterface
		{
			Register<TInterface, TImplementation>(isSingleton: true);
			return this;
		}

		public IDependencyInjectorBuilder RegisterSingletonWithImplementation<TInterface>(TInterface implementation)
			where TInterface : class?
		{
			Register<TInterface, TInterface>(implementation: implementation, isSingleton: true);
			return this;
		}

		public IDependencyInjectorBuilder Register<TInterface, TImplementation>(TImplementation? implementation = null, bool isSingleton = false)
			where TInterface : class?
			where TImplementation : class?, TInterface
		{
			var builder = new DependencyDescriptorBuilder();
			builder.SetInterfaceType(typeof(TInterface));
			builder.SetImplementationType(typeof(TImplementation));
			builder.SetImplementation(implementation);
			builder.SetSingleton(isSingleton);
			_dependencyCollection.Register(builder.Build());

			return this;
		}

		public IDependencyInjector Build()
		{
			var mediator = BuildServicesMediator();
			var settings = BuildSettings(mediator);
			return new DependencyInjector(settings);
		}

		private IServicesMediator BuildServicesMediator()
		{
			var builder = new ServicesMediatorBuilder();
			builder.SetDependencyBuilder(new DependencyBuilder());
			builder.SetDependencyCollection(_dependencyCollection);
			builder.SetDependencySolver(new DependencySolver());

			return builder.Build();
		}

		private DependencyInjectorSettings BuildSettings(IServicesMediator mediator)
		{
			var settings = new DependencyInjectorSettings();
			settings.ServicesMediator = mediator;
			return settings;
		}
	}
}
