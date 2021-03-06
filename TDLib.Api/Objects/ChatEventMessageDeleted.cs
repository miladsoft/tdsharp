using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatEventAction : Object
        {
            public class ChatEventMessageDeleted : ChatEventAction
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatEventMessageDeleted";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message")]
                public Message Message { get; set; }
            }
        }
    }
}