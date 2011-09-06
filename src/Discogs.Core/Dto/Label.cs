using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Discogs.Core.Dto
{
    [Serializable]
    [DataContract(Name = "label")]
    public class Label
    {
        [DataMember(IsRequired = false, Name = "catno")]
        public string CatNo { get; set; }

        [DataMember(IsRequired = false, Name = "name")]
        public string Name { get; set; }

        [DataMember(IsRequired = false, Name = "parentLabel")]
        public string ParentLabel { get; set; }

        [DataMember(IsRequired = false, Name = "releases")]
        public List<Release> Releases { get; set; }

        [DataMember(IsRequired = false, Name = "sublabels")]
        public List<string> Sublabels { get; set; }

        [DataMember(IsRequired = false, Name = "images")]
        public List<Image> Images { get; set; }

        [DataMember(IsRequired = false, Name = "contactinfo")]
        public string Contactinfo { get; set; }
    }
}