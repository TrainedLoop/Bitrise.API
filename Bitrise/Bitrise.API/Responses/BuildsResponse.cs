using Bitrise.API.Models;

namespace Bitrise.API.Responses
{
    public class BuildsResponse
    {
        public BuildResponseItem[] data { get; set; }
        public Paging paging { get; set; }
    }
}