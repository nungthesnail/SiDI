namespace SiDI
{
	internal class DependencyDescriptorBuilder : IDependencyDescriptorBuilder
	{
		private Type? _interfaceType;
		private Type? _implType;
		private object? _impl;
		private bool _isSingleton = false;

		public void SetInterfaceType(Type interfaceType) => _interfaceType = interfaceType;
		public void SetImplementationType(Type implementationType) => _implType = implementationType;
		public void SetImplementation(object? implementation) => _impl = implementation;
		public void SetSingleton(bool isSingleton) => _isSingleton = isSingleton;

		public IDependencyDescriptor Build()
		{
			ThrowIfBuildingIsntCompleted();
			ThrowIfImplementationIsntAncestorOfInterface();
			var settings = BuildDescriptorSettings();

			return new DependencyDescriptor(settings);
		}

		private void ThrowIfBuildingIsntCompleted()
		{
			if (_interfaceType is null || _implType is null && _impl is null)
				throw new InvalidOperationException("Cannot create dependency descriptor because interface type or implementation type isn\'t specified");
		}

		private void ThrowIfImplementationIsntAncestorOfInterface()
		{
			if (_impl is null)
			{
				if (!_interfaceType!.IsAssignableFrom(_implType))
					throw new InvalidOperationException("Cannot create dependency descriptor because implementation type isn\'t ancestor of interface type");
			}
			else
			{
				if (!_interfaceType!.IsAssignableFrom(_impl.GetType()))
					throw new InvalidOperationException("Cannot create dependency descriptor because implementation isn\'t ancestor of interface type");
			}
		}

		private DependencyDescriptorSettings BuildDescriptorSettings()
		{
			var settings = new DependencyDescriptorSettings();
			settings.InterfaceType = _interfaceType!;
			settings.ImplementationType = _implType!;
			settings.Implementation = _impl;
			settings.IsSingleton = _isSingleton;

			return settings;
		}
	}
}
