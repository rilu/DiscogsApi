using System;
using System.Runtime.Serialization;

namespace Discogs.Core.Api
{
    [Serializable]
    [DataContract(Name = "image")]
    public class Image
    {
        [DataMember(IsRequired = false, Name = "width")]
        public int Width { get; set; }

        [DataMember(IsRequired = false, Name = "uri150")]
        public string Uri150 { get; set; }

        [DataMember(IsRequired = false, Name = "type")]
        public string Type { get; set; }

        [DataMember(IsRequired = false, Name = "uri")]
        public string Uri { get; set; }

        [DataMember(IsRequired = false, Name = "height")]
        public int Height { get; set; }
    }
}