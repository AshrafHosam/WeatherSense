using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Common.EventOpenDataHub
{
    public class NullableLongConverter : JsonConverter<long?>
    {
        public override long? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt64(out var l))
                return l;
            if (reader.TokenType == JsonTokenType.String)
            {
                var s = reader.GetString();
                if (string.IsNullOrWhiteSpace(s))
                    return null;
                if (long.TryParse(s, out var result))
                    return result;
                return null;
            }
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            // Instead of throwing, just return null for any other token type
            return null;
        }
        public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
            else
                writer.WriteNullValue();
        }
    }
}
