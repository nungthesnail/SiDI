namespace SiDI
{
	internal class DependencyDescriptorSettings
	{
		public Type InterfaceType { get; set; } = null!;
		public Type ImplementationType { get; set; } = null!;
		public object? Implementation { get; set; } = null;
		public bool IsSingleton { get; set; } = false;
	}
}
