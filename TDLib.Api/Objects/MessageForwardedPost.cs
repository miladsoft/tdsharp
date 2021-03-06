using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class MessageForwardInfo : Object
        {
            public class MessageForwardedPost : MessageForwardInfo
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "messageForwardedPost";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("author_signature")]
                public string AuthorSignature { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("date")]
                public int Date { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("forwarded_from_chat_id")]
                public long ForwardedFromChatId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("forwarded_from_message_id")]
                public long ForwardedFromMessageId { get; set; }
            }
        }
    }
}