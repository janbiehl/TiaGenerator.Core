using TiaGenerator.Core.Interfaces;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace TiaGenerator.Core.Services
{
	public abstract class YamlSerializer
	{
		public ISerializer Serializer { get; set; } = DefaultSerializer;
		public IDeserializer Deserializer { get; set; } = DefaultDeserializer;

		private static readonly IDeserializer DefaultDeserializer = new DeserializerBuilder()
			.WithNamingConvention(UnderscoredNamingConvention.Instance)
			//.WithAttributeOverride(typeof(GeneratorAction), "Type", new YamlMemberAttribute {Alias = "type"})
			.WithTagMapping("!CreatePlcAction", typeof(ICreatePlcAction))
			.WithTagMapping("!OpenProjectAction", typeof(IOpenProjectAction))
			.WithTagMapping("!CopyProjectAction", typeof(ICopyProjectAction))
			.Build();

		private static readonly ISerializer DefaultSerializer = new SerializerBuilder()
			.WithIndentedSequences()
			//.WithNamingConvention(UnderscoredNamingConvention.Instance)
			.WithTagMapping("!CreatePlcAction", typeof(ICreatePlcAction))
			.WithTagMapping("!OpenProjectAction", typeof(IOpenProjectAction))
			.WithTagMapping("!CopyProjectAction", typeof(ICopyProjectAction))
			.Build();
	}
}