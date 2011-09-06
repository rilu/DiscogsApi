using System;
using System.Runtime.Serialization;

namespace Discogs.Core.Api
{
    [Serializable]
    [DataContract(Name = "tracklist")]
    public class Tracklist
    {
        [DataMember(IsRequired = false, Name = "duration")]
        public string Duration { get; set; }

        [DataMember(IsRequired = false, Name = "position")]
        public string Position { get; set; }

        [DataMember(IsRequired = false, Name = "title")]
        public string Title { get; set; }
    }
}