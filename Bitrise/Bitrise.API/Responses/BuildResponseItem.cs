using Bitrise.API.Models;
using System;

namespace Bitrise.API.Responses
{
    public class BuildResponseItem
    {
        public DateTime triggered_at { get; set; }
        public string started_on_worker_at { get; set; }
        public string environment_prepare_finished_at { get; set; }
        public string finished_at { get; set; }
        public string slug { get; set; }
        public int status { get; set; }
        public string status_text { get; set; }
        public string abort_reason { get; set; }
        public bool is_on_hold { get; set; }
        public string branch { get; set; }
        public int build_number { get; set; }
        public string commit_hash { get; set; }
        public string commit_message { get; set; }
        public string tag { get; set; }
        public string triggered_workflow { get; set; }
        public string triggered_by { get; set; }
        public string stack_config_type { get; set; }
        public string stack_identifier { get; set; }
        public OriginalBuildParams original_build_params { get; set; }
        public int pull_request_id { get; set; }
        public string pull_request_target_branch { get; set; }
        public string pull_request_view_url { get; set; }
        public string commit_view_url { get; set; }
        public Repository repository { get; set; }
    }
}