namespace TPLink.SmartHome
{
	/// <summary>
	/// Describes the device type
	/// </summary>
	public enum SystemType
	{
		Unknown,
		Plug,
		PlugWithEnergyMeter,
		Bulb
	}

	/// <summary>
	/// Holds system information about the device.
	/// </summary>
	public class SystemInfo
	{
		#region Public Properties

		public string FirmwareVersion { get; }
		public string Id { get; }
		public decimal LocationLat { get; }
		public decimal LocationLon { get; }
		public string Model { get; }
		public string Name { get; }
		public SystemType Type { get; }

		#endregion

		#region Protected Internal Constructors

		protected internal SystemInfo(string name, string id, SystemType type, string model, string firmwareVersion, decimal locationLat, decimal locationLon)
		{
			this.Name = name;
			this.Id = id;
			this.Type = type;
			this.Model = model;
			this.FirmwareVersion = firmwareVersion;
			this.LocationLat = locationLat;
			this.LocationLon = locationLon;
		}

		#endregion

		#region Public Methods

		public override string ToString()
		{
			return Type.ToString() + " " + Name;
		}

		#endregion
	}
}