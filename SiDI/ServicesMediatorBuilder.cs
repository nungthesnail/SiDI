namespace SiDI
{
	internal class ServicesMediatorBuilder : IServicesMediatorBuilder
	{
		private IDependencyBuilder? _builder;
		private IDependencyCollection? _collection;
		private IDependencySolver? _solver;

		public void SetDependencyBuilder(IDependencyBuilder builder) => _builder = builder;
		public void SetDependencyCollection(IDependencyCollection collection) => _collection = collection;
		public void SetDependencySolver(IDependencySolver solver) => _solver = solver;

		public IServicesMediator Build()
		{
			ThrowIfBuildingIsntCompleted();

			var settings = new ServicesMediatorSettings();
			settings.DependencyBuilder = _builder!;
			settings.DependencyCollection = _collection!;
			settings.DependencySolver = _solver!;

			return new ServicesMediator(settings);
		}

		private void ThrowIfBuildingIsntCompleted()
		{
			if (_builder is null
				|| _collection is null
				|| _solver is null)
			{
				throw new InvalidOperationException("Cannot create services mediator because some services isn\'t specified");
			}
		}
	}
}
