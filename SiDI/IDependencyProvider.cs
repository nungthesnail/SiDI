namespace SiDI
{
	public interface IDependencyProvider
	{
		T Request<T>() where T : class;
	}
}
