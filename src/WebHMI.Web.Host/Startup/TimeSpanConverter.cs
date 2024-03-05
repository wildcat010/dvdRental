using System;
using Newtonsoft.Json;

namespace WebHMI.Web.Host.Startup
{
	/// <summary>
	/// TimeSpans are not serialized consistently depending on what properties are present.
	/// So this serializer will ensure the format is maintained no matter what.
	/// </summary>
	public class TimeSpanConverter : JsonConverter<TimeSpan>
	{
		private const string _timeSpanFormatString = @"d\.hh\:mm\:ss\.fff";

		public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer)
		{
			var timespanFormatted = value.ToString(_timeSpanFormatString);
			writer.WriteValue(timespanFormatted);
		}

		public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			TimeSpan.TryParseExact((string)reader.Value, _timeSpanFormatString, null, out TimeSpan parsedTimeSpan);
			return parsedTimeSpan;
		}
	}
}
