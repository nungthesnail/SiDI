namespace SiDI
{
	internal interface IServicesMediatorBuilder
	{
		IServicesMediator Build();
		void SetDependencyBuilder(IDependencyBuilder builder);
		void SetDependencyCollection(IDependencyCollection collection);
		void SetDependencySolver(IDependencySolver solver);
	}
}