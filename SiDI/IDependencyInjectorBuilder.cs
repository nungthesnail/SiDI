namespace SiDI
{
	public interface IDependencyInjectorBuilder
	{
		IDependencyInjectorBuilder RegisterTransient<TInterface, TImplementation>()
			where TInterface : class?
			where TImplementation : class?, TInterface;

		IDependencyInjectorBuilder RegisterSingleton<TInterface, TImplementation>()
			where TInterface : class?
			where TImplementation : class?, TInterface;

		IDependencyInjectorBuilder RegisterSingletonWithImplementation<TInterface>(TInterface implementation)
			where TInterface : class?;

		IDependencyInjector Build();
	}
}
