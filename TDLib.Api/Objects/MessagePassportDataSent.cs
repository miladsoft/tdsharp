using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class MessageContent : Object
        {
            public class MessagePassportDataSent : MessageContent
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "messagePassportDataSent";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("types")]
                public PassportElementType[] Types { get; set; }
            }
        }
    }
}