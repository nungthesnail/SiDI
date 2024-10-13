namespace SiDI
{
	public class DependencyInjector : IDependencyInjector
	{
		private readonly IServicesMediator _mediator;

        internal DependencyInjector(DependencyInjectorSettings settings)
        {
            _mediator = settings.ServicesMediator;
        }

        public T Request<T>()
			where T : class
		{
			return (T)(typeof(T).GetConstructor([])!.Invoke([]));
		}
	}
}
