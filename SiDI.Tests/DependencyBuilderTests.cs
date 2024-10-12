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
			IDependencyBuilder dependencyBuilder = new DependencyBuilder();

			// Act
			IDependencyProvider dependencyProvider = dependencyBuilder.Build();

			// Assert
			Assert.NotNull(dependencyProvider);
		}

		[Fact]
		public void TestRegisterTransient_InputIsIMockInterfaceAndMockImplementation_ResultIsNotNull()
		{
			// Arrange
			IDependencyBuilder dependencyBuilder = new DependencyBuilder();
			dependencyBuilder.RegisterTransient<IMockInterface, MockImplementation>();

			// Act
			IDependencyProvider dependencyProvider = dependencyBuilder.Build();

			// Assert
			Assert.NotNull(dependencyProvider.Request<IMockInterface>());
		}

		[Fact]
		public void TestRegisterSingleton_InputIsIMockInterfaceAndMockImplementation_ResultIsNotNull()
		{
			// Arrange
			IDependencyBuilder dependencyBuilder = new DependencyBuilder();
			dependencyBuilder.RegisterSingleton<IMockInterface, MockImplementation>();

			// Act
			IDependencyProvider dependencyProvider = dependencyBuilder.Build();

			// Assert
			Assert.NotNull(dependencyProvider.Request<IMockInterface>());
		}

		[Fact]
		public void TestRegisterSingleton_InputIsIMockInterfaceAndMockImplementation_ResultsAreEqual()
		{
			// Arrange
			IDependencyBuilder dependencyBuilder = new DependencyBuilder();
			dependencyBuilder.RegisterSingleton<IMockInterface, MockImplementation>();

			// Act
			IDependencyProvider dependencyProvider = dependencyBuilder.Build();
			var requested1 = dependencyProvider.Request<IMockInterface>();
			var requested2 = dependencyProvider.Request<IMockInterface>();

			// Assert
			Assert.Equal(requested1, requested2);
		}

		[Fact]
		public void TestRegisterSingletonWithImplementation_InputIsIMockInterfaceAndImplementation_ResultIsNotNull()
		{
			// Arrange
			IDependencyBuilder dependencyBuilder = new DependencyBuilder();
			IMockInterface mockImplementation = new MockImplementation();
			dependencyBuilder.RegisterSingletonWithImplementation(mockImplementation);

			// Act
			IDependencyProvider dependencyProvider = dependencyBuilder.Build();

			// Assert
			Assert.NotNull(dependencyProvider.Request<IMockInterface>());
		}

		[Fact]
		public void TestRegisterSingletonWithImplementation_InputIsIMockInterfaceAndImplementation_ResultAreEqual()
		{
			// Arrange
			IDependencyBuilder dependencyBuilder = new DependencyBuilder();
			IMockInterface mockImplementation = new MockImplementation();
			dependencyBuilder.RegisterSingletonWithImplementation(mockImplementation);

			// Act
			IDependencyProvider dependencyProvider = dependencyBuilder.Build();
			var requested1 = dependencyProvider.Request<IMockInterface>();
			var requested2 = dependencyProvider.Request<IMockInterface>();

			// Assert
			Assert.Equal(requested1, requested2);
		}
	}
}