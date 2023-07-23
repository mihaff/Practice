using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Practice.Utils.Converters
{
    public class IntJsonConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var str = reader.GetString() ?? "0";
            var value = int.Parse(str);
            return value;
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
