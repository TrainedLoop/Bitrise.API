namespace Bitrise.API.Models
{
    public class Repository
    {
        public string slug { get; set; }
        public string title { get; set; }
        public string project_type { get; set; }
        public string provider { get; set; }
        public string repo_owner { get; set; }
        public string repo_url { get; set; }
        public string repo_slug { get; set; }
        public bool is_disabled { get; set; }
        public int status { get; set; }
        public bool is_public { get; set; }
        public Owner owner { get; set; }
        public string avatar_url { get; set; }
    }
}