namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// This action opens a existing Siemens TIA Portal project
	/// </summary>
	public interface IOpenProjectAction
	{
		/// <summary>
		/// The path to the siemens project file
		/// </summary>
		/// <remarks>Might also be a archive file (.zapXX)</remarks>
		public string? ProjectFilePath { get; set; }

		/// <summary>
		/// The username for the project
		/// </summary>
		public string? Username { get; set; }

		/// <summary>
		/// The password for the project
		/// </summary>
		public string? Password { get; set; }
	}
}