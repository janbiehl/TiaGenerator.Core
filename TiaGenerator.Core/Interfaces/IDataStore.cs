namespace TiaGenerator.Core.Interfaces
{
	public interface IDataStore
	{
		public void SetValue<T>(string key, T value) where T : class, new();

		public T? GetValue<T>(string key) where T : class, new();
	}
}