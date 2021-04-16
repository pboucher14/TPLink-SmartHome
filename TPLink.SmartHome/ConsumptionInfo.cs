namespace TPLink.SmartHome
{
	/// <summary>
	/// Holds information about the energy monitor's power consumption.
	/// </summary>
	public sealed class ConsumptionInfo
	{
		#region Public Properties

		public decimal Current { get; }
		public decimal Power { get; }
		public decimal Voltage { get; }

		#endregion

		#region Internal Constructors

		internal ConsumptionInfo(decimal power, decimal voltage, decimal current)
		{
			this.Power = power;
			this.Voltage = voltage;
			this.Current = current;
		}

		#endregion
	}
}