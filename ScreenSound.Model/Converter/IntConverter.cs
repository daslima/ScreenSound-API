using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScreenSound.Model
{
    public class IntConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return int.Parse(reader.GetString()!);
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
           writer.WriteNumberValue(value);
        }
    }
}