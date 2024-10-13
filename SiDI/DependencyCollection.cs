using SiDI.Exceptions;

namespace SiDI
{
	internal class DependencyCollection : IDependencyCollection
	{
		private readonly Dictionary<Type, IDependencyDescriptor> _descriptors = new();

		public DependencyCollection()
		{ }

		public DependencyCollection(Dictionary<Type, IDependencyDescriptor> descriptors)
		{
			_descriptors = descriptors;
		}

		public void Register(IDependencyDescriptor descriptor)
		{
			var descriptorKey = descriptor.InterfaceType;
			_descriptors.Add(descriptorKey, descriptor);
		}

		public IDependencyDescriptor Get(Type interfaceType)
		{
			try
			{
				return _descriptors[interfaceType];
			}
			catch (KeyNotFoundException)
			{
				throw new DependencyNotFoundException($"Dependency with interface type {interfaceType.FullName} isn\'t exists in dependency collection");
			}
		}

		public bool IsRegistered(Type interfaceType) => _descriptors.ContainsKey(interfaceType);

		public void Remove(Type interfaceType)
		{
			_descriptors.Remove(interfaceType);
		}
	}
}
