using System;
using System.Runtime.Serialization;

namespace Discogs.Core.Dto
{
    [Serializable]
    [DataContract(Name = "extraartist")]
    public class ExtraArtist
    {
        [DataMember(IsRequired = false, Name = "tracks")]
        public string Tracks { get; set; }

        [DataMember(IsRequired = false, Name = "role")]
        public string Role { get; set; }

        [DataMember(IsRequired = false, Name = "anv")]
        public string Anv { get; set; }

        [DataMember(IsRequired = false, Name = "join")]
        public string Join { get; set; }

        [DataMember(IsRequired = false, Name = "name")]
        public string Name { get; set; }
    }
}