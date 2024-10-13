namespace SiDI
{
	internal class DependencyBuilder : IDependencyBuilder
	{
		public T Build<T>(DependencyBuildingInfo? buildingInfo = null)
			where T : class?
		{
			throw new NotImplementedException();
		}
	}
}
