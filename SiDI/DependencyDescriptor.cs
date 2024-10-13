namespace SiDI
{
	internal class DependencyDescriptor : IDependencyDescriptor
	{
		public Type InterfaceType { get; }
		public Type ImplementationType { get; }
		public Object? Implementation { get; }
		public bool IsSingleton { get; }

		internal DependencyDescriptor(DependencyDescriptorSettings settings)
		{
			InterfaceType = settings.InterfaceType;
			ImplementationType = settings.ImplementationType;
			Implementation = settings.Implementation;
			IsSingleton = settings.IsSingleton;
		}
	}
}
