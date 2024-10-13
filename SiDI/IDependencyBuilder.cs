namespace SiDI
{
	internal interface IDependencyBuilder
	{
		T Build<T>(DependencyBuildingInfo? buildingInfo = null)
			where T : class?;
	}
}