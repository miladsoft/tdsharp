using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ConnectionState : Object
        {
            public class ConnectionStateUpdating : ConnectionState
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "connectionStateUpdating";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}