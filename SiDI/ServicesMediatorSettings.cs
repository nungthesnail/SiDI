namespace SiDI
{
	internal class ServicesMediatorSettings
	{
		public IDependencyBuilder DependencyBuilder { get; set; } = null!;
		public IDependencyCollection DependencyCollection { get; set; } = null!;
		public IDependencySolver DependencySolver { get; set; } = null!;
	}
}
