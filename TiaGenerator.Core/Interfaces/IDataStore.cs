namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// Interface for the data store. This is used to store data between actions.
	/// </summary>
	public interface IDataStore
	{
		/// <summary>
		/// Set value in the data store.
		/// </summary>
		/// <param name="key">The key for the value</param>
		/// <param name="value">The value to insert/set</param>
		/// <typeparam name="T">Type of the value to add</typeparam>
		public void SetValue<T>(string key, T value);

		/// <summary>
		/// Get value from the data store.
		/// </summary>
		/// <param name="key">The key assigned to that value</param>
		/// <typeparam name="T">The type of the value</typeparam>
		/// <returns>The value or null</returns>
		public T? GetValue<T>(string key);
	}
}