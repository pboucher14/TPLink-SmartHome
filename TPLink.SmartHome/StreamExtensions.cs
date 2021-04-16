using System.Threading.Tasks;

namespace TPLink.SmartHome
{
	internal static class StreamExtensions
	{
		#region Public Methods

		public static int ReadBlock(this System.IO.Stream stream, byte[] buffer, int offset, int count)
		{
			int bufferLength = 0;
			while (bufferLength < count)
			{
				int readLength = stream.Read(buffer, offset + bufferLength, count - bufferLength);
				if (readLength == 0)
				{
					break;
				}
				bufferLength += readLength;
			}

			return bufferLength;
		}

		public static async Task<int> ReadBlockAsync(this System.IO.Stream stream, byte[] buffer, int offset, int count)
		{
			int bufferLength = 0;
			while (bufferLength < count)
			{
				int readLength = await stream.ReadAsync(buffer, offset + bufferLength, count - bufferLength).ConfigureAwait(false);
				if (readLength == 0)
				{
					break;
				}
				bufferLength += readLength;
			}

			return bufferLength;
		}

		#endregion
	}
}