namespace TPLink.SmartHome
{
	/// <summary>
	/// Holds information about device's cloud binding.
	/// </summary>
	public sealed class CloudInfo
	{
		#region Public Properties

		public string Username { get; }

		#endregion

		#region Internal Constructors

		internal CloudInfo(string username)
		{
			this.Username = username;
		}

		#endregion
	}
}