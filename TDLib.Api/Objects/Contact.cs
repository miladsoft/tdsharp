using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class Contact : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "contact";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("phone_number")]
            public string PhoneNumber { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("first_name")]
            public string FirstName { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_name")]
            public string LastName { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("vcard")]
            public string Vcard { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }
        }
    }
}