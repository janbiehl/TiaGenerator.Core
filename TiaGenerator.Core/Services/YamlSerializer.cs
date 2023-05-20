using System;
using System.IO;
using System.Linq;
using System.Text;
using TiaGenerator.Core.Models;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace TiaGenerator.Core.Services
{
	/// <summary>
	/// A serializer that uses yaml as format
	/// </summary>
	public class YamlSerializer : ISerializer
	{
		/// <summary>
		/// The serializer to use
		/// </summary>
		public YamlDotNet.Serialization.ISerializer Serializer { get; set; } = DefaultSerializer;

		/// <summary>
		/// The deserializer to use
		/// </summary>
		public YamlDotNet.Serialization.IDeserializer Deserializer { get; set; } = DefaultDeserializer;

		/// <summary>
		/// The default serializer to use
		/// </summary>
		private static readonly YamlDotNet.Serialization.ISerializer DefaultSerializer;

		/// <summary>
		/// The default deserializer to use
		/// </summary>
		private static readonly YamlDotNet.Serialization.IDeserializer DefaultDeserializer;

		/// <summary>
		/// Static constructor that initializes the default serializer and deserializer
		/// </summary>
		static YamlSerializer()
		{
			// Create a serializer and deserializer with the underscore naming convention
			var serializerBuilder = new SerializerBuilder()
				.WithNamingConvention(UnderscoredNamingConvention.Instance);

			var deserializerBuilder = new DeserializerBuilder()
				.WithNamingConvention(UnderscoredNamingConvention.Instance);

			// Get any type that inherits from GeneratorAction 
			foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				var values = assembly.GetTypes().Where(type => typeof(GeneratorAction).IsAssignableFrom(type));

				// Add the tag mapping for each type to the serializer & deserializer
				foreach (var value in values)
				{
					serializerBuilder.WithTagMapping($"!{value.Name}", value);
					deserializerBuilder.WithTagMapping($"!{value.Name}", value);
				}
			}

			// Build the serializer
			DefaultSerializer = serializerBuilder.Build();
			DefaultDeserializer = deserializerBuilder.Build();
		}

		/// <inheritdoc />
		public void Serialize<T>(string filePath, T data)
		{
			if (File.Exists(filePath))
				throw new InvalidOperationException($"File '{filePath}' already exists.");

			using var fileStream = File.OpenWrite(filePath);
			using var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);

			Serializer.Serialize(streamWriter, data);
		}

		/// <inheritdoc />
		public void Serialize<T>(Stream stream, T data)
		{
			using var streamWriter = new StreamWriter(stream, Encoding.UTF8);

			Serializer.Serialize(streamWriter, data);
		}

		/// <inheritdoc />
		public T Deserialize<T>(string filePath)
		{
			if (!File.Exists(filePath))
				throw new FileNotFoundException("The file does not exist", filePath);

			using var fileStream = File.OpenRead(filePath);
			using var streamReader = new StreamReader(fileStream, Encoding.UTF8);

			return Deserializer.Deserialize<T>(streamReader);
		}

		/// <inheritdoc />
		public T Deserialize<T>(Stream stream)
		{
			using var streamReader = new StreamReader(stream, Encoding.UTF8);

			return Deserializer.Deserialize<T>(streamReader);
		}
	}
}