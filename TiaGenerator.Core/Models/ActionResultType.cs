namespace TiaGenerator.Core.Models
{
	/// <summary>
	/// The result type of an action
	/// </summary>
	public enum ActionResultType
	{
		/// <summary>
		/// The action finished successfully
		/// </summary>
		Success,

		/// <summary>
		/// The action failed, the generator can continue
		/// </summary>
		Failure,

		/// <summary>
		/// The action failed, the generator should stop
		/// </summary>
		Fatal
	}
}