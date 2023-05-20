namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// This is a action that copies a existing Siemens TIA Portal project to a new project
	/// </summary>
	/// <remarks>
	///	The source project might also be a archive file (.zapXX)
	/// </remarks>
	public interface ICopyProjectAction : IAction
	{
		/// <summary>
		/// The path to the source project file
		/// </summary>
		/// <remarks>
		///	The source project might also be a archive file (.zapXX)
		/// </remarks>
		string? SourceProjectFile { get; set; }

		/// <summary>
		/// The path to the directory where the project will be copied to 
		/// </summary>
		string? TargetProjectDirectory { get; set; }
	}
}