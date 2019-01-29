using RestSharp;

namespace Bitrise.API
{
    public class BitriseApi
    {
        internal readonly string accessToken;
        internal RestClient RestClient { get; set; }

        internal BitriseApi(string accessToken)
        {
            this.accessToken = accessToken;
            RestClient = new RestClient("https://api.bitrise.io/v0.1/");
        }
    }
}