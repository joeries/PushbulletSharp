using System.Runtime.Serialization;

namespace PushbulletSharp.Models.Requests
{
    [DataContract]
    public class DeleteTextRequest
    {
        /// <summary>
        /// Gets or sets the iden.
        /// </summary>
        /// <value>
        /// The iden.
        /// </value>
        [DataMember(Name = "iden")]
        public string Iden { get; set; }
    }
}