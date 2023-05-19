using TiaGenerator.Core.Interfaces;

namespace TiaGenerator.Core.Models
{
	public abstract class GeneratorAction
	{
		public string? Type { get; set; }

		public abstract ActionResult Execute(IDataStore datastore);
	}
}