using System.Text.Json.Serialization;

public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary

    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

public class Feature
{
    [JsonPropertyName("properties")]
    public Property Properties { get; set; }
}

public class Property
{
    [JsonPropertyName("mag")]
    public decimal Mag { get; set; }

    [JsonPropertyName("place")]
    public string Place { get; set; }
}