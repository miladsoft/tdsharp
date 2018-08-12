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
            public class MessageChatUpgradeTo : MessageContent
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "messageChatUpgradeTo";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_id")]
                public int SupergroupId { get; set; }
            }
        }
    }
}