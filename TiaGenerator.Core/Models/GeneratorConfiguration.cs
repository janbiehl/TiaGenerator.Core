// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable CollectionNeverUpdated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using System.Collections.Generic;

namespace TiaGenerator.Core.Models
{
	public sealed class GeneratorConfiguration
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? Author { get; set; }
		public List<GeneratorAction>? Actions { get; set; }
	}
}