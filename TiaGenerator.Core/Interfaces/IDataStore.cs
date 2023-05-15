namespace TiaGenerator.Core.Interfaces
{
	public interface IDataStore
	{
		public T GetValue<T>(string name);
	}
}