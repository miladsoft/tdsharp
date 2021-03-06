using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetSavedAnimations : Function<Animations>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getSavedAnimations";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}