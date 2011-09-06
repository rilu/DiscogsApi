using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Discogs.Core.Api;

namespace Discogs.Core.Dto
{
    [Serializable]
    [DataContract(Name = "release")]
    public class Release
    {
        [DataMember(IsRequired = false, Name = "status")]
        public string Status { get; set; }

        [DataMember(IsRequired = false, Name = "styles")]
        public List<string> Styles { get; set; }

        [DataMember(IsRequired = false, Name = "genres")]
        public List<string> Genres { get; set; }

        [DataMember(IsRequired = false, Name = "labels")]
        public List<Label> Labels { get; set; }

        [DataMember(IsRequired = false, Name = "extraartists")]
        public List<ExtraArtist> ExtraArtists { get; set; }

        [DataMember(IsRequired = false, Name = "title")]
        public string Title { get; set; }

        [DataMember(IsRequired = false, Name = "country")]
        public string Country { get; set; }

        [DataMember(IsRequired = false, Name = "notes")]
        public string Notes { get; set; }

        [DataMember(IsRequired = false, Name = "artists")]
        public List<Artist> Artists { get; set; }

        [DataMember(IsRequired = false, Name = "released")]
        public string Released { get; set; }

        [DataMember(IsRequired = false, Name = "released_formatted")]
        public string ReleasedFormatted { get; set; }

        [DataMember(IsRequired = false, Name = "formats")]
        public List<Format> Formats { get; set; }

        [DataMember(IsRequired = false, Name = "year")]
        public int Year { get; set; }

        [DataMember(IsRequired = false, Name = "images")]
        public List<Image> Images { get; set; }

        [DataMember(IsRequired = false, Name = "master_id")]
        public int MasterId { get; set; }

        [DataMember(IsRequired = false, Name = "tracklist")]
        public List<Tracklist> Tracklist { get; set; }

        [DataMember(IsRequired = false, Name = "id")]
        public int Id { get; set; }

        [DataMember(IsRequired = false, Name = "format")]
        public string Format { get; set; }

        [DataMember(IsRequired = false, Name = "label")]
        public string Label { get; set; }

        [DataMember(IsRequired = false, Name = "trackinfo")]
        public string Trackinfo { get; set; }

        [DataMember(IsRequired = false, Name = "artist")]
        public string Artist { get; set; }

        [DataMember(IsRequired = false, Name = "type")]
        public string Type { get; set; }

        [DataMember(IsRequired = false, Name = "catno")]
        public string CatNo { get; set; }
    }
}