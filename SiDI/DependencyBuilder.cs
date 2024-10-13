namespace SiDI
{
	internal class DependencyBuilder : IDependencyBuilder, IInternalService
	{
		private IServicesMediator _mediator = null!;

		public void SetServicesMediator(IServicesMediator mediator) => _mediator = mediator;

        public T Build<T>(DependencyBuildingInfo? buildingInfo = null)
			where T : class?
		{
			throw new NotImplementedException();
		}
	}
}
