using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PassportElementErrorSource : Object
        {
            public class PassportElementErrorSourceTranslationFile : PassportElementErrorSource
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementErrorSourceTranslationFile";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}