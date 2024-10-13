namespace SiDI
{
	internal class ServicesMediator : IServicesMediator
	{
		private readonly IDependencyBuilder _builder;
		private readonly IDependencyCollection _collection;
		private readonly IDependencySolver _solver;

		public ServicesMediator(ServicesMediatorSettings settings)
		{
			_builder = settings.DependencyBuilder;
			_collection = settings.DependencyCollection;
			_solver = settings.DependencySolver;
		}

		public IDependencyBuilder GetDependencyBuilder() => _builder;
		public IDependencyCollection GetDependencyCollection() => _collection;
		public IDependencySolver GetDependencySolver() => _solver;
	}
}
