namespace SiDI.Exceptions
{
	public class DependencyNotFoundException : Exception
	{
        public DependencyNotFoundException(string? message = null)
            : base(message) { }
    }
}
