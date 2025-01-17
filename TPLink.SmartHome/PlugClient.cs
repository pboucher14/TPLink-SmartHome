﻿using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace TPLink.SmartHome
{
	/// <summary>
	/// Provides TP-Link Smart Home client for Power Plug functionality.
	/// </summary>
	public class PlugClient : Client
	{
		#region Public Constructors

		public PlugClient(IPAddress address, ProtocolType protocolType = ProtocolType.Udp) :
						base(address, protocolType)
		{
		}

		public PlugClient(string hostname, ProtocolType protocolType = ProtocolType.Udp) :
				base(hostname, protocolType)
		{
		}

		#endregion

		#region Public Methods

		public OutputState GetOutput()
		{
			return this.GetOutputAsync().ConfigureAwait(false).GetAwaiter().GetResult();
		}
		public async Task<OutputState> GetOutputAsync()
		{
			JToken resultToken = await this.ExecuteAsync("system", "get_sysinfo").ConfigureAwait(false);
			return (OutputState)resultToken.SelectToken("relay_state").Value<int>();
		}
		public void SetOutput(OutputState state)
		{
			this.SetOutputAsync(state).ConfigureAwait(false).GetAwaiter().GetResult();
		}
		public Task SetOutputAsync(OutputState state)
		{
			return this.ExecuteAsync("system", "set_relay_state",
					new JProperty("state", (int)state));
		}

		#endregion
	}
}