namespace TPLink.SmartHome
{
	/// <summary>
	/// Holds information about the energy monitor calibration.
	/// </summary>
	public sealed class CalibrationInfo
	{
		#region Public Properties

		public decimal CurrentGain { get; }
		public decimal VoltageGain { get; }

		#endregion

		#region Public Constructors

		public CalibrationInfo(int voltageGain, int currentGain)
		{
			this.VoltageGain = voltageGain;
			this.CurrentGain = currentGain;
		}

		#endregion
	}
}