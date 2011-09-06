using System;
using System.Runtime.Serialization;

namespace Discogs.Core.Api
{
    [Serializable]
    [DataContract(Name = "version")]
    public class Version
    {
        [DataMember(IsRequired = false, Name = "status")]
        public string Status { get; set; }

        [DataMember(IsRequired = false, Name = "thumb")]
        public string Thumb { get; set; }

        [DataMember(IsRequired = false, Name = "format")]
        public string Format { get; set; }

        [DataMember(IsRequired = false, Name = "country")]
        public string Country { get; set; }

        [DataMember(IsRequired = false, Name = "title")]
        public string Title { get; set; }

        [DataMember(IsRequired = false, Name = "label")]
        public string Label { get; set; }

        [DataMember(IsRequired = false, Name = "released")]
        public string Released { get; set; }

        [DataMember(IsRequired = false, Name = "catno")]
        public string CatNo { get; set; }

        [DataMember(IsRequired = false, Name = "id")]
        public int Id { get; set; }
    }
}