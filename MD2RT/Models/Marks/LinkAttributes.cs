using Newtonsoft.Json;

namespace MD2RT.Models.Marks;

public class LinkAttributes : MarkAttributes
{
  [JsonProperty(NullValueHandling=NullValueHandling.Include)]
  public string? Target { get; set; }

  [JsonProperty(NullValueHandling=NullValueHandling.Include)]
  public string? Href { get; set; }

  [JsonProperty(NullValueHandling=NullValueHandling.Include)]
  public string? Class { get; set; }

  public override bool Include()
  {
    return !string.IsNullOrEmpty(this.Target) || !string.IsNullOrEmpty(this.Href);
  }
}
