namespace SiDI.Tests
{
	public class DependencyBuilderAndDependencyProviderTests
	{
		private interface IMockInterface
		{ }

		private class MockImplementation : IMockInterface
		{ }

		[Fact]
		public void TestBuild_InputIsEmpty_ResultIsNotNull()
		{
			// Arrange
			IDependencyInjectorBuilder dependencyBuilder = new DependencyInjectorBuilder();

			// Act
			IDependencyInjector dependencyProvider = dependencyBuilder.Build();

			// Assert
			Assert.NotNull(dependencyProvider);
		}

		[Fact]
		public void TestRegisterTransient_InputIsIMockInterfaceAndMockImplementation_ResultIsNotNull()
		{
			// Arrange
			IDependencyInjectorBuilder dependencyBuilder = new DependencyInjectorBuilder();
			dependencyBuilder.RegisterTransient<IMockInterface, MockImplementation>();

			// Act
			IDependencyInjector dependencyProvider = dependencyBuilder.Build();

			// Assert
			Assert.NotNull(dependencyProvider.Request<IMockInterface>());
		}

		[Fact]
		public void TestRegisterSingleton_InputIsIMockInterfaceAndMockImplementation_ResultIsNotNull()
		{
			// Arrange
			IDependencyInjectorBuilder dependencyBuilder = new DependencyInjectorBuilder();
			dependencyBuilder.RegisterSingleton<IMockInterface, MockImplementation>();

			// Act
			IDependencyInjector dependencyProvider = dependencyBuilder.Build();

			// Assert
			Assert.NotNull(dependencyProvider.Request<IMockInterface>());
		}

		[Fact]
		public void TestRegisterSingleton_InputIsIMockInterfaceAndMockImplementation_ResultsAreEqual()
		{
			// Arrange
			IDependencyInjectorBuilder dependencyBuilder = new DependencyInjectorBuilder();
			dependencyBuilder.RegisterSingleton<IMockInterface, MockImplementation>();

			// Act
			IDependencyInjector dependencyProvider = dependencyBuilder.Build();
			var requested1 = dependencyProvider.Request<IMockInterface>();
			var requested2 = dependencyProvider.Request<IMockInterface>();

			// Assert
			Assert.Equal(requested1, requested2);
		}

		[Fact]
		public void TestRegisterSingletonWithImplementation_InputIsIMockInterfaceAndImplementation_ResultIsNotNull()
		{
			// Arrange
			IDependencyInjectorBuilder dependencyBuilder = new DependencyInjectorBuilder();
			IMockInterface mockImplementation = new MockImplementation();
			dependencyBuilder.RegisterSingletonWithImplementation(mockImplementation);

			// Act
			IDependencyInjector dependencyProvider = dependencyBuilder.Build();

			// Assert
			Assert.NotNull(dependencyProvider.Request<IMockInterface>());
		}

		[Fact]
		public void TestRegisterSingletonWithImplementation_InputIsIMockInterfaceAndImplementation_ResultAreEqual()
		{
			// Arrange
			IDependencyInjectorBuilder dependencyBuilder = new DependencyInjectorBuilder();
			IMockInterface mockImplementation = new MockImplementation();
			dependencyBuilder.RegisterSingletonWithImplementation(mockImplementation);

			// Act
			IDependencyInjector dependencyProvider = dependencyBuilder.Build();
			var requested1 = dependencyProvider.Request<IMockInterface>();
			var requested2 = dependencyProvider.Request<IMockInterface>();

			// Assert
			Assert.Equal(requested1, requested2);
		}
	}
}