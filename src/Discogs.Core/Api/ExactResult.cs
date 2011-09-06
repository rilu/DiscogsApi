using System;
using System.Runtime.Serialization;

namespace Discogs.Core.Api
{
    [Serializable]
    [DataContract(Name = "exactresult")]
    public class ExactResult
    {
        public ExactResult()
        {
        }

        [DataMember(IsRequired = false, Name = "anv")]
        public string Anv { get; set; }

        [DataMember(IsRequired = false, Name = "type")]
        public string Type { get; set; }

        [DataMember(IsRequired = false, Name = "uri")]
        public string Uri { get; set; }

        [DataMember(IsRequired = false, Name = "title")]
        public string Title { get; set; }
    }
}