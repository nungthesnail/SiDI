namespace SiDI
{
	public interface IDependencyInjector
	{
		T Request<T>() where T : class;
	}
}
