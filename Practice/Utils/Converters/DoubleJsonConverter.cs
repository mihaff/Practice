using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Practice.Utils.Converters
{
    public class DoubleJsonConverter : JsonConverter<double>
    {
        public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var str = reader.GetString() ?? "0";
            str = str.Replace(".", ",");
            var value = Convert.ToDouble(str);
            return value;
        }

        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
