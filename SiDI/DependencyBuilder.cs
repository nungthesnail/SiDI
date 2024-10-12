namespace SiDI
{
	public class DependencyBuilder : IDependencyBuilder
	{
		public IDependencyBuilder RegisterTransient<TInterface, TImplementation>()
			where TInterface : class
			where TImplementation : TInterface
		{
			throw new NotImplementedException();
		}

		public IDependencyBuilder RegisterSingleton<TInterface, TImplementation>()
			where TInterface : class
			where TImplementation : TInterface
		{
			throw new NotImplementedException();
		}

		public IDependencyBuilder RegisterSingletonWithImplementation<TInterface>(TInterface implementation)
			where TInterface : class
		{
			throw new NotImplementedException();
		}

		public IDependencyProvider Build()
		{
			throw new NotImplementedException();
		}
	}
}
