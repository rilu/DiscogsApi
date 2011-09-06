using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Discogs.Api;

namespace Discogs.Core.Api
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