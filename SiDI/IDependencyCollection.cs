
namespace SiDI
{
	internal interface IDependencyCollection : IInternalService
	{
		IDependencyDescriptor Get(Type interfaceType);
		bool IsRegistered(Type interfaceType);
		void Register(IDependencyDescriptor descriptor);
		void Remove(Type interfaceType);
	}
}