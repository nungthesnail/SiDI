namespace SiDI
{
	internal interface IDependencySolver
	{
		T Solve<T>()
			where T : class?;
	}
}