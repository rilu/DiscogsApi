using Discogs.Core.Dto;

namespace Discogs.Core.Interfaces
{
    public interface IDiscogsService
    {
        Artist Artist(string artistName, bool includeReleases = false);
        Release Release(int releaseId);
        Master MasterRelease(int masterReleaseId);
        Label Label(string label, bool includeReleases = false);
        Search Search(string query, SearchTypes searchType = SearchTypes.all, int page = 1);
    }
}