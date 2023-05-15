namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// This action creates a new plc in the project
	/// </summary>
	public interface ICreatePlcAction
	{
		/// <summary>
		/// The name the new plc should have
		/// </summary>
		string? PlcName { get; set; }
		
		/// <summary>
		/// The siemens order number for the generated plc
		/// </summary>
		string? PlcOrderNumber { get; set; }
	}
}