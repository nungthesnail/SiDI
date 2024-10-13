namespace SiDI
{
	internal class DependencySolver : IDependencySolver, IInternalService
	{
		private IServicesMediator _mediator = null!;

		public void SetServicesMediator(IServicesMediator mediator) => _mediator = mediator;

		public T Solve<T>()
			where T : class?
		{
			throw new NotImplementedException();
		}
	}
}
