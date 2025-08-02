using PushbulletSharp.Models.Responses;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Principal;
using System.Xml;

namespace PushbulletSharp.Models.Requests
{
    [DataContract]
    public class UpdateTextRequest
    {
        /// <summary>
        /// Gets or sets the iden.
        /// </summary>
        /// <value>
        /// The iden.
        /// </value>
        [DataMember(Name = "iden")]
        public string Iden { get; set; }

        [DataMember(Name = "skip_delete_file")]
        public bool SkipDeleteFile { get; set; }

        [DataMember(Name = "data")]
        public TextData Data { get; set; }
    }
}