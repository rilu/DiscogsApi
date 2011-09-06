using System;
using System.Runtime.Serialization;

namespace Discogs.Core.Dto
{
    [Serializable]
    [DataContract(Name = "video")]
    public class Video
    {
        [DataMember(IsRequired = false, Name = "uri")]
        public string Uri { get; set; }

        [DataMember(IsRequired = false, Name = "duration")]
        public int Duration { get; set; }

        [DataMember(IsRequired = false, Name = "embed")]
        public bool Embed { get; set; }

        [DataMember(IsRequired = false, Name = "description")]
        public string Description { get; set; }

        [DataMember(IsRequired = false, Name = "title")]
        public string Title { get; set; }
    }
}