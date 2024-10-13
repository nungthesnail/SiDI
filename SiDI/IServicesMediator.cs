namespace SiDI
{
	internal interface IServicesMediator
	{
		IDependencyBuilder GetDependencyBuilder();
		IDependencyCollection GetDependencyCollection();
		IDependencySolver GetDependencySolver();
	}
}