using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InputPassportElement : Object
        {
            public class InputPassportElementTemporaryRegistration : InputPassportElement
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementTemporaryRegistration";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("temporary_registration")]
                public InputPersonalDocument TemporaryRegistration { get; set; }
            }
        }
    }
}