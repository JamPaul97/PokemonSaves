using System;
namespace PokeAPI.EndPoints.Item.Bases
{
    [Serializable]
    public class Sprites
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "dafault")]
        public string @default;
    }
}
