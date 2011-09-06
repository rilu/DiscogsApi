using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Discogs.Core.Dto
{
    [Serializable]
    [DataContract(Name = "searchresults")]
    public class Searchresults
    {
        [DataMember(IsRequired = false, Name = "numResults")]
        public string NumResults { get; set; }

        [DataMember(IsRequired = false, Name = "start")]
        public string Start { get; set; }

        [DataMember(IsRequired = false, Name = "end")]
        public string End { get; set; }

        [DataMember(IsRequired = false, Name = "results")]
        public List<Result> Results { get; set; }
    }
}