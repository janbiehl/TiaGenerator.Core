namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// This action creates a new tia instance
	/// </summary>
	public interface ICreateTiaInstanceAction : IAction
	{
		/// <summary>
		/// Whether the new instance should be created with interface or not
		/// </summary>
		public bool WithInterface { get; set; }
	}
}