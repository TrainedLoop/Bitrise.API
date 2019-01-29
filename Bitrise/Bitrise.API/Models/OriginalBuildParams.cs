namespace Bitrise.API.Models
{
    public class OriginalBuildParams
    {
        public string branch { get; set; }
        public string workflow_id { get; set; }
        public Environment[] environments { get; set; }
    }
}