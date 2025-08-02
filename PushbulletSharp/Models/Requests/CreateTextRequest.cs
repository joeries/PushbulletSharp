using PushbulletSharp.Models.Responses;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Principal;
using System.Xml;

namespace PushbulletSharp.Models.Requests
{
    [DataContract]
    public class CreateTextRequest
    {
        /// <summary>
        /// Gets or sets the file_url.
        /// </summary>
        /// <value>
        /// The file_url.
        /// </value>
        [DataMember(Name = "file_url")]
        public string FileUrl { get; set; }

        [DataMember(Name = "skip_delete_file")]
        public bool SkipDeleteFile { get; set; }

        [DataMember(Name = "data")]
        public TextData Data { get; set; }
    }
}