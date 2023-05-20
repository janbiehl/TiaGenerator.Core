namespace TiaGenerator.Core.Models
{
	/// <summary>
	/// The result type of an action
	/// </summary>
	public struct ActionResult
	{
		/// <summary>
		/// The result of the action
		/// </summary>
		public ActionResultType Result { get; set; }

		/// <summary>
		/// The message of the action
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="result">The result the action finished with</param>
		/// <param name="message">The message to describe the actions run</param>
		public ActionResult(ActionResultType result, string message)
		{
			Result = result;
			Message = message;
		}
	}
}