using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class FinishFileGeneration : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "finishFileGeneration";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("generation_id")]
            public Int64 GenerationId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("error")]
            public Error Error { get; set; }
        }
    }
}