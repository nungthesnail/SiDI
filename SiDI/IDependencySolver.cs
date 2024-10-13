namespace SiDI
{
	internal interface IDependencySolver : IInternalService
	{
		T Solve<T>()
			where T : class?;
	}
}