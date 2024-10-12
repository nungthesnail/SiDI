namespace SiDI
{
	public interface IDependencyBuilder
	{
		IDependencyBuilder RegisterTransient<TInterface, TImplementation>()
			where TInterface : class
			where TImplementation : TInterface;

		IDependencyBuilder RegisterSingleton<TInterface, TImplementation>()
			where TInterface : class
			where TImplementation : TInterface;

		IDependencyBuilder RegisterSingletonWithImplementation<TInterface>(TInterface implementation)
			where TInterface : class;

		IDependencyProvider Build();
	}
}
