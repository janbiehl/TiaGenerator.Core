namespace TiaGenerator.Core.Interfaces
{
	/// <summary>
	/// Action that will close the currently opened project
	/// </summary>
	public interface ICloseProjectAction : IAction
	{
		/// <summary>
		/// If true, the project will be saved before closing
		/// </summary>
		public bool SaveProject { get; set; }
	}
}