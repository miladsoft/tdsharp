using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetCountryCode : Function<Text>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getCountryCode";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}