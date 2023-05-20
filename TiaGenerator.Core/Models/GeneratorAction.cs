using System.Threading.Tasks;
using TiaGenerator.Core.Interfaces;

namespace TiaGenerator.Core.Models
{
	public struct GeneratorActionResult
	{
		public ActionResult Result { get; set; }

		public string Message { get; set; }

		public GeneratorActionResult(ActionResult result, string message)
		{
			Result = result;
			Message = message;
		}
	}

	public abstract class GeneratorAction
	{
		public string? Type { get; set; }

		public abstract Task<GeneratorActionResult> Execute(IDataStore datastore);
	}
}