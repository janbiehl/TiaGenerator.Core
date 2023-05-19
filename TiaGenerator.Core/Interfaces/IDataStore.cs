namespace TiaGenerator.Core.Interfaces
{
	public interface IDataStore
	{
		public void SetValue<T>(string key, T value);

		public T? GetValue<T>(string key);
	}
}