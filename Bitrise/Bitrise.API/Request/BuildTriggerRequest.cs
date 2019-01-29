using Bitrise.API.Models;

namespace Bitrise.API.Request
{
    public class BuildTriggerRequest
    {
        public BuildTriggerRequest(HookInfo hookInfo, BuildParams buildParams)
        {
            hook_info = hookInfo;
            build_params = buildParams;
        }

        public HookInfo hook_info { get; set; }
        public BuildParams build_params { get; set; }
    }
}