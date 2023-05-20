using System.Threading.Tasks;
using TiaGenerator.Core.Interfaces;

namespace TiaGenerator.Core.Models
{
	/// <summary>
	/// The base class for a generator action
	/// </summary>
	public abstract class GeneratorAction : IAction
	{
		/// <summary>
		/// The type of the action. This is used to identify the action in the configuration.
		/// </summary>
		public string? Type { get; set; }

		/// <summary>
		/// This method executes the action using a datastore to store data between actions.
		/// </summary>
		/// <remarks>
		///	The action can Get or Set values on the datastore.
		/// </remarks>
		/// <param name="datastore">Used to share data between actions</param>
		/// <returns>A <see cref="ActionResult"/> object to describe the actions run</returns>
		public abstract Task<ActionResult> Execute(IDataStore datastore);
	}
}