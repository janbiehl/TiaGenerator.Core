namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// Interface for all actions that can be executed by the generator.
	/// </summary>
	public interface IAction
	{
		/// <summary>
		/// The type of the action. This is used to identify the action in the configuration.
		/// </summary>
		public string Type { get; set; }
	}
}