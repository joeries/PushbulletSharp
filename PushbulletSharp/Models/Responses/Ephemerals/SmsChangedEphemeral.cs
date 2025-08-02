using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PushbulletSharp.Models.Responses.Ephemerals
{
    [DataContract]
    public class SmsChangedEphemeral : IEphemeral
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the source_device_iden.
        /// </summary>
        /// <value>
        /// The source_device_iden.
        /// </value>
        [DataMember(Name = "source_device_iden")]
        public string SourceDeviceIden { get; set; }

        [DataMember(Name = "notifications")]
        public List<SmsChangedEphemeralNotification> Notifications { get; set; }
    }

    [DataContract]
    public class SmsChangedEphemeralNotification
    {
        [DataMember(Name = "thread_id")]
        public string ThreadId { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "timestamp")]
        public long Timestamp { get; set; }
    }
}