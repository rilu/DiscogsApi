using System;
using System.Runtime.Serialization;

namespace Discogs.Api
{
    [Serializable]
    [DataContract(Name = "result")]
    public class Result
    {
        [DataMember(IsRequired = false, Name = "title")]
        public string Title { get; set; }

        [DataMember(IsRequired = false, Name = "type")]
        public string Type { get; set; }

        [DataMember(IsRequired = false, Name = "uri")]
        public string Uri { get; set; }

        [DataMember(IsRequired = false, Name = "summary")]
        public string Summary { get; set; }
    }
}