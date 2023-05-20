namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// Find a plc by name in a TIA project
	/// </summary>
	public interface IGetPlcAction : IAction
	{
		/// <summary>
		/// The name of the plc to get
		/// </summary>
		public string? PlcName { get; set; }
	}
}