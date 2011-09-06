namespace Discogs.Core.Impl
{
    public class DiscogsSettings
    {
        public string ApiKey { get; private set; }
        public string DiscogsUrl { get; private set; }

        public DiscogsSettings(string apiKey, string discogsUrl)
        {
            this.ApiKey = apiKey;
            this.DiscogsUrl = discogsUrl.TrimEnd(new[] { '/' }); 
        }
    }
}
