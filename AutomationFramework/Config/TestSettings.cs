using AutomationFramework.Base;
using Newtonsoft.Json;

namespace AutomationFramework.Config
{
    [JsonObject("testSettings")]
    public class TestSettings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("aut")]
        public string AUT { get; set; }

        [JsonProperty("browser")]
        public BrowserType Browser { get; set; }

    }
}
