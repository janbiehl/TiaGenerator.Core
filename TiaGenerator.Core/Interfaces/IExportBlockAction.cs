namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// Export a block to a file using the block name
	/// </summary>
	public interface IExportBlockAction : IAction
	{
		/// <summary>
		/// The name of the block to export
		/// </summary>
		public string? BlockName { get; set; }

		/// <summary>
		/// The path to export the block to
		/// </summary>
		public string? FilePath { get; set; }
	}
}