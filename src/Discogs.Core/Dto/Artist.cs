using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Discogs.Core.Api;

namespace Discogs.Core.Dto
{
    [Serializable]
    [DataContract(Name="artist")]
    public class Artist
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

        [DataMember(IsRequired = false, Name = "images")]
        public List<Image> Images { get; set; }

        [DataMember(IsRequired = false, Name = "releases")]
        public List<Release> Releases { get; set; }

        [DataMember(IsRequired = false, Name = "groups")]
        public List<string> Groups { get; set; }

        [DataMember(IsRequired = false, Name = "namevariations")]
        public List<string> NameVariations { get; set; }
    }
}