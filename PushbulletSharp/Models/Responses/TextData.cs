using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PushbulletSharp.Models.Responses
{
    [DataContract]
    public class TextData
    {
        [DataMember(Name = "addresses")]
        public List<string> Addresses { get; set; }

        [DataMember(Name = "file_type")]
        public string FileType { get; set; }

        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "target_device_iden")]
        public string TargetDeviceIden { get; set; }
    }
}
