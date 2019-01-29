using Bitrise.API.Request;
using Bitrise.API.Responses;
using RestSharp;
using System.Threading.Tasks;

namespace Bitrise.API
{
    public class Builds : BitriseApi
    {
        public Builds(string accessToken) : base(accessToken)
        {
        }

        public async Task<BuildsResponse> ListBuildsAsync()
        {
            var request = new RestRequest("builds", Method.GET);

            var result = await RestClient.ExecuteTaskAsync<BuildsResponse>(request)
                .ConfigureAwait(false);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            else
            {
                throw new System.Exception(result.Content, result.ErrorException);
            }
        }

        public async Task<BuildResponse> GetBuildAsync(string appSlug, string buildSlug)
        {
            var request = new RestRequest($"apps/{appSlug}/builds/{buildSlug}", Method.GET);

            var result = await RestClient.ExecuteTaskAsync<BuildResponse>(request)
                .ConfigureAwait(false);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            else
            {
                throw new System.Exception(result.Content, result.ErrorException);
            }
        }

        public async Task<TriggerBuildResponse> TriggerBuildAsync(string appSlug, BuildTriggerRequest buildTrigger)
        {
            var request = new RestRequest($"/app/{appSlug}/build/start.json", Method.POST);
            request.AddJsonBody(buildTrigger);
            var result = await RestClient.ExecuteTaskAsync<TriggerBuildResponse>(request);
            if (result.IsSuccessful)
            {
                return result.Data;
            }
            else
            {
                throw new System.Exception(result.Content, result.ErrorException);
            }
        }
    }
}