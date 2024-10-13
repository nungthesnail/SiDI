namespace SiDI
{
	internal interface IDependencyBuilder : IInternalService
	{
		T Build<T>(DependencyBuildingInfo? buildingInfo = null)
			where T : class?;
	}
}