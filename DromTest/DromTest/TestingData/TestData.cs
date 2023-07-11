using System.Text.Json.Serialization;

namespace DromTest.TestingData;
public class TestData
{
    [JsonPropertyName("brand")]
    public string? Brand { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("transmission")]
    public string? Transmission { get; set; }

    [JsonPropertyName("drive")]
    public string? Drive { get; set; }

    [JsonPropertyName("bodyType")]
    public string? BodyType { get; set; }

    [JsonPropertyName("wheel")]
    public string? Wheel { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }
}
