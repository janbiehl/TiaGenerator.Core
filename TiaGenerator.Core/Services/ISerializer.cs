using System.IO;

namespace TiaGenerator.Core.Services
{
	/// <summary>
	/// Interface for a serializer, that is able to serialize and deserialize data
	/// </summary>
	public interface ISerializer
	{
		/// <summary>
		/// Serialize data to a file
		/// </summary>
		/// <param name="filePath">The path for the file to serialize the data to</param>
		/// <param name="data">The data to serialize</param>
		/// <typeparam name="T">The type of data to serialize</typeparam>
		void Serialize<T>(string filePath, T data);

		/// <summary>
		/// Serialize data to a stream
		/// </summary>
		/// <param name="stream">The stream to serialize the data to</param>
		/// <param name="data">The data to serialize</param>
		/// <typeparam name="T">The type of data to serialize</typeparam>
		void Serialize<T>(Stream stream, T data);

		/// <summary>
		/// Deserialize data from a file
		/// </summary>
		/// <param name="filePath">The file to deserialize</param>
		/// <typeparam name="T">The type of data to deserializer</typeparam>
		/// <returns>The deserialized data or null</returns>
		T? Deserialize<T>(string filePath);

		/// <summary>
		/// Deserialize data from a stream
		/// </summary>
		/// <param name="stream">The stream to deserialize from</param>
		/// <typeparam name="T">The type of data to deserialize</typeparam>
		/// <returns>The deserialized data or null</returns>
		T? Deserialize<T>(Stream stream);
	}
}