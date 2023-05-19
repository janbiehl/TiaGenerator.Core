// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable CollectionNeverUpdated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiaGenerator.Core.Models
{
	public sealed class GeneratorConfiguration
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? Author { get; set; }
		public List<GeneratorAction>? Actions { get; set; }

		/// <inheritdoc />
		public override string ToString()
		{
			StringBuilder builder = new();

			builder.AppendLine($"Name: {Name}");
			builder.Append($"Description: {Description}");
			builder.Append($"Author: {Author}");

			builder.AppendLine("Actions:");

			foreach (var action in Actions ?? Enumerable.Empty<GeneratorAction>())
			{
				builder.AppendLine($"	{action.Type}");
			}

			return builder.ToString();
		}
	}
}