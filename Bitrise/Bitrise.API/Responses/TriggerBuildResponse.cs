namespace Bitrise.API.Request
{
    public class TriggerBuildResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public string slug { get; set; }
        public string service { get; set; }
        public string build_slug { get; set; }
        public int build_number { get; set; }
        public string build_url { get; set; }
        public string triggered_workflow { get; set; }
    }
}