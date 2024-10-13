
namespace SiDI
{
	internal interface IDependencyDescriptorBuilder
	{
		IDependencyDescriptor Build();
		void SetImplementation(object? implementation);
		void SetImplementationType(Type implementationType);
		void SetInterfaceType(Type interfaceType);
		void SetSingleton(bool isSingleton);
	}
}