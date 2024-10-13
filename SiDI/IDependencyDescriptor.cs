namespace SiDI
{
	internal interface IDependencyDescriptor
	{
		Object? Implementation { get; }
		Type ImplementationType { get; }
		Type InterfaceType { get; }
		bool IsSingleton { get; }
	}
}