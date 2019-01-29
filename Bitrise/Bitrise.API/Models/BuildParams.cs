using System.Collections.Generic;
using System.Linq;

namespace Bitrise.API.Models
{
    public class BuildParams
    {
        public BuildParams(string branch, string workflowId, IEnumerable<Environment> environments = null)
        {
            this.branch = branch;
            workflow_id = workflowId;
            this.environments = environments?.ToList();
        }

        public string branch { get; set; }
        public string workflow_id { get; set; }
        public List<Environment> environments { get; set; }
    }
}