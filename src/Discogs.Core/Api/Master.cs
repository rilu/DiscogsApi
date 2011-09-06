using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Discogs.Api;
using Version = Discogs.Core.Api.Version;

namespace Discogs.Core.Api
{
    [Serializable]
    [DataContract(Name = "master")]
    public class Master
    {
        [DataMember(IsRequired = false, Name = "styles")]
        public List<string> Styles { get; set; }

        [DataMember(IsRequired = false, Name = "genres")]
        public List<string> Genres { get; set; }

        [DataMember(IsRequired = false, Name = "videos")]
        public List<Video> Videos { get; set; }

        [DataMember(IsRequired = false, Name = "versions")]
        public List<Version> Versions { get; set; }

        [DataMember(IsRequired = false, Name = "main_release")]
        public int MainRelease { get; set; }

        [DataMember(IsRequired = false, Name = "notes")]
        public string Notes { get; set; }

        [DataMember(IsRequired = false, Name = "artists")]
        public List<Artist> Artists { get; set; }

        [DataMember(IsRequired = false, Name = "year")]
        public int Year { get; set; }

        [DataMember(IsRequired = false, Name = "images")]
        public List<Image> Images { get; set; }

        [DataMember(IsRequired = false, Name = "tracklist")]
        public List<Tracklist> Tracklist { get; set; }

        [DataMember(IsRequired = false, Name = "id")]
        public int Id { get; set; }
    }
}