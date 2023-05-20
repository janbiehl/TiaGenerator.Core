using System.Collections.Generic;

namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// Action to process a blocks content and import it to the project
	/// </summary>
	public interface IImportAndProcessBlock : IAction
	{
		/// <summary>
		/// The source path of the block to import
		/// </summary>
		public string? BlockSourceFile { get; set; }

		/// <summary>
		/// The destination path of the block to import
		/// </summary>
		public string? BlockDestinationFile { get; set; }

		/// <summary>
		/// The block group to import the block to. Separated by '/'.
		/// </summary>
		public string? BlockGroup { get; set; }

		/// <summary>
		/// The templates to replace in the block file
		/// </summary>
		/// <remarks>
		/// Regex are used to replace the templates. So the key could be a regex expression
		/// </remarks>
		public List<KeyValuePair<string, string>>? Templates { get; set; }
	}
}