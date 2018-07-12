// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using API_Call_Template;
//
//    var chuckNorris = ChuckNorris.FromJson(jsonString);

namespace API_Call_Template
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ChuckNorris
    {
        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class ChuckNorris
    {
        public static ChuckNorris FromJson(string json) => JsonConvert.DeserializeObject<ChuckNorris>(json, API_Call_Template.Converter.Settings);
    }

    /*
    public static class Serialize
    {
        public static string ToJson(this ChuckNorris self) => JsonConvert.SerializeObject(self, API_Call_Template.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    } */
}
