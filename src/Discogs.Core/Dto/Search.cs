using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Discogs.Core.Dto
{
    [Serializable]
    [DataContract(Name = "search")]
    public class Search
    {
        [DataMember(IsRequired = false, Name = "searchresults")]
        public Searchresults Searchresults { get; set; }

        [DataMember(IsRequired = false, Name = "exactresults")]
        public List<ExactResult> ExactResults { get; set; }
    }
}