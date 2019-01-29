namespace Bitrise.API.Models
{
    public class HookInfo
    {
        public HookInfo(string buildTriggerToken, string type = "bitrise")
        {
            build_trigger_token = buildTriggerToken;
            this.type = type;
        }

        public string type { get; set; }
        public string build_trigger_token { get; set; }
    }
}