using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Discogs.Core.Api
{
    [Serializable]
    [DataContract(Name = "format")]
    public class Format
    {
        [DataMember(IsRequired = false, Name = "descriptions")]
        public List<string> Descriptions { get; set; }

        [DataMember(IsRequired = false, Name = "name")]
        public string Name { get; set; }

        [DataMember(IsRequired = false, Name = "qty")]
        public string Quantity { get; set; }
    }
}