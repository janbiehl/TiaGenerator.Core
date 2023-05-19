using System;
using System.IO;
using System.Text;
using TiaGenerator.Core.Interfaces;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace TiaGenerator.Core.Services
{
	public interface ISerializer
	{
		void Serialize<T>(string filePath, T data);
		void Serialize<T>(Stream stream, T data);

		T Deserialize<T>(string filePath);
		T Deserialize<T>(Stream stream);
	}

	public class YamlSerializer : ISerializer
	{
		public YamlDotNet.Serialization.ISerializer Serializer { get; set; } = DefaultSerializer;
		public YamlDotNet.Serialization.IDeserializer Deserializer { get; set; } = DefaultDeserializer;

		private static readonly YamlDotNet.Serialization.IDeserializer DefaultDeserializer = new DeserializerBuilder()
			.WithNamingConvention(UnderscoredNamingConvention.Instance)
			//.WithAttributeOverride(typeof(GeneratorAction), "Type", new YamlMemberAttribute {Alias = "type"})
			.WithTagMapping("!CreatePlcAction", typeof(ICreatePlcAction))
			.WithTagMapping("!OpenProjectAction", typeof(IOpenProjectAction))
			.WithTagMapping("!CopyProjectAction", typeof(ICopyProjectAction))
			.WithTagMapping("!CreateTiaInstanceAction", typeof(ICreateTiaInstanceAction))
			.Build();

		private static readonly YamlDotNet.Serialization.ISerializer DefaultSerializer = new SerializerBuilder()
			.WithIndentedSequences()
			//.WithNamingConvention(UnderscoredNamingConvention.Instance)
			.WithTagMapping("!CreatePlcAction", typeof(ICreatePlcAction))
			.WithTagMapping("!OpenProjectAction", typeof(IOpenProjectAction))
			.WithTagMapping("!CopyProjectAction", typeof(ICopyProjectAction))
			.WithTagMapping("!CreateTiaInstanceAction", typeof(ICreateTiaInstanceAction))
			.Build();

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