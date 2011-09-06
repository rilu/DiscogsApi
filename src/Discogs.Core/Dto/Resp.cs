using System;
using System.Runtime.Serialization;
using Discogs.Core.Api;

namespace Discogs.Core.Dto
{
    [Serializable]
    [DataContract(Name = "resp")]
    public class Resp
    {
        [DataMember(IsRequired = false, Name = "status")]
        public bool Status { get; set; }

        [DataMember(IsRequired = false, Name = "release")]
        public Release Release { get; set; }

        [DataMember(IsRequired = false, Name = "label")]
        public Label Label { get; set; }

        [DataMember(IsRequired = false, Name = "artist")]
        public Artist Artist { get; set; }

        [DataMember(IsRequired = false, Name = "search")]
        public Search Search { get; set; }

        [DataMember(IsRequired = false, Name = "requests")]
        public int Requests { get; set; }

        [DataMember(IsRequired = false, Name = "version")]
        public string Version { get; set; }

        [DataMember(IsRequired = false, Name = "master")]
        public Master Master { get; set; }
    }
}
