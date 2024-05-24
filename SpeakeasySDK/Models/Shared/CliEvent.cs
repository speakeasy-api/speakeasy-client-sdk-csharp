//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Shared
{
    using Newtonsoft.Json;
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    using System;
    
    public class CliEvent
    {

        /// <summary>
        /// Remote commit ID.
        /// </summary>
        [JsonProperty("commit_head")]
        public string? CommitHead { get; set; }

        /// <summary>
        /// Name of the CI environment.
        /// </summary>
        [JsonProperty("continuous_integration_environment")]
        public string? ContinuousIntegrationEnvironment { get; set; }

        /// <summary>
        /// Timestamp when the event was created in the database.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Duration of the event in milliseconds.
        /// </summary>
        [JsonProperty("duration_ms")]
        public long? DurationMs { get; set; }

        /// <summary>
        /// Error message if the event was not successful.
        /// </summary>
        [JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Unique identifier for each execution of the CLI.
        /// </summary>
        [JsonProperty("execution_id")]
        public string ExecutionId { get; set; } = default!;

        /// <summary>
        /// Bump type of the lock file (calculated semver delta, or a custom change (manual release))
        /// </summary>
        [JsonProperty("generate_bump_type")]
        public GenerateBumpType? GenerateBumpType { get; set; }

        /// <summary>
        /// Checksum of the configuration file (post generation)
        /// </summary>
        [JsonProperty("generate_config_post_checksum")]
        public string? GenerateConfigPostChecksum { get; set; }

        /// <summary>
        /// Rendered configuration file (post generation)
        /// </summary>
        [JsonProperty("generate_config_post_raw")]
        public string? GenerateConfigPostRaw { get; set; }

        /// <summary>
        /// The version of the customer&apos;s SDK that we just generated
        /// </summary>
        [JsonProperty("generate_config_post_version")]
        public string? GenerateConfigPostVersion { get; set; }

        /// <summary>
        /// Checksum of the configuration file (prior to generation)
        /// </summary>
        [JsonProperty("generate_config_pre_checksum")]
        public string? GenerateConfigPreChecksum { get; set; }

        /// <summary>
        /// Rendered configuration file (prior to generation)
        /// </summary>
        [JsonProperty("generate_config_pre_raw")]
        public string? GenerateConfigPreRaw { get; set; }

        /// <summary>
        /// The version of the customer&apos;s SDK before we generated
        /// </summary>
        [JsonProperty("generate_config_pre_version")]
        public string? GenerateConfigPreVersion { get; set; }

        /// <summary>
        /// Eligible feature set during generation
        /// </summary>
        [JsonProperty("generate_eligible_features")]
        public string? GenerateEligibleFeatures { get; set; }

        /// <summary>
        /// gen.lock ID (expected to be a uuid).
        /// </summary>
        [JsonProperty("generate_gen_lock_id")]
        public string? GenerateGenLockId { get; set; }

        /// <summary>
        /// Features post generation
        /// </summary>
        [JsonProperty("generate_gen_lock_post_features")]
        public string? GenerateGenLockPostFeatures { get; set; }

        /// <summary>
        /// Blob digest of the Previous Generation
        /// </summary>
        [JsonProperty("generate_gen_lock_pre_blob_digest")]
        public string? GenerateGenLockPreBlobDigest { get; set; }

        /// <summary>
        /// Checksum of the Previous Rendered OpenAPI document (prior to generation, via gen lock)
        /// </summary>
        [JsonProperty("generate_gen_lock_pre_doc_checksum")]
        public string? GenerateGenLockPreDocChecksum { get; set; }

        /// <summary>
        /// info.Version of the Previous Rendered OpenAPI document (prior to generation, via gen lock)
        /// </summary>
        [JsonProperty("generate_gen_lock_pre_doc_version")]
        public string? GenerateGenLockPreDocVersion { get; set; }

        /// <summary>
        /// Features prior to generation
        /// </summary>
        [JsonProperty("generate_gen_lock_pre_features")]
        public string? GenerateGenLockPreFeatures { get; set; }

        /// <summary>
        /// Namespace name of the Previous Generation
        /// </summary>
        [JsonProperty("generate_gen_lock_pre_namespace_name")]
        public string? GenerateGenLockPreNamespaceName { get; set; }

        /// <summary>
        /// Revision digest of the Previous Generation
        /// </summary>
        [JsonProperty("generate_gen_lock_pre_revision_digest")]
        public string? GenerateGenLockPreRevisionDigest { get; set; }

        /// <summary>
        /// Artifact version for the Previous Generation
        /// </summary>
        [JsonProperty("generate_gen_lock_pre_version")]
        public string? GenerateGenLockPreVersion { get; set; }

        /// <summary>
        /// The number of operations ignored in generation.
        /// </summary>
        [JsonProperty("generate_number_of_operations_ignored")]
        public long? GenerateNumberOfOperationsIgnored { get; set; }

        /// <summary>
        /// The number of operations used in generation.
        /// </summary>
        [JsonProperty("generate_number_of_operations_used")]
        public long? GenerateNumberOfOperationsUsed { get; set; }

        /// <summary>
        /// Indicates whether tests were output.
        /// </summary>
        [JsonProperty("generate_output_tests")]
        public bool? GenerateOutputTests { get; set; }

        /// <summary>
        /// Indicates whether the target was considered published.
        /// </summary>
        [JsonProperty("generate_published")]
        public bool? GeneratePublished { get; set; }

        /// <summary>
        /// Expected Repo URL, for use in documentation generation.
        /// </summary>
        [JsonProperty("generate_repo_url")]
        public string? GenerateRepoUrl { get; set; }

        /// <summary>
        /// The target of the event.
        /// </summary>
        [JsonProperty("generate_target")]
        public string? GenerateTarget { get; set; }

        /// <summary>
        /// The version of the target.
        /// </summary>
        [JsonProperty("generate_target_version")]
        public string? GenerateTargetVersion { get; set; }

        /// <summary>
        /// Version of the generation logic used.
        /// </summary>
        [JsonProperty("generate_version")]
        public string? GenerateVersion { get; set; }

        /// <summary>
        /// GitHub organization of the action.
        /// </summary>
        [JsonProperty("gh_action_organization")]
        public string? GhActionOrganization { get; set; }

        /// <summary>
        /// GitHub Action ref value.
        /// </summary>
        [JsonProperty("gh_action_ref")]
        public string? GhActionRef { get; set; }

        /// <summary>
        /// GitHub repository of the action.
        /// </summary>
        [JsonProperty("gh_action_repository")]
        public string? GhActionRepository { get; set; }

        /// <summary>
        /// Link to the GitHub action run.
        /// </summary>
        [JsonProperty("gh_action_run_link")]
        public string? GhActionRunLink { get; set; }

        /// <summary>
        /// Version of the GitHub action.
        /// </summary>
        [JsonProperty("gh_action_version")]
        public string? GhActionVersion { get; set; }

        /// <summary>
        /// Current working directory relative to the git root.
        /// </summary>
        [JsonProperty("git_relative_cwd")]
        public string? GitRelativeCwd { get; set; }

        /// <summary>
        /// Default owner for git remote.
        /// </summary>
        [JsonProperty("git_remote_default_owner")]
        public string? GitRemoteDefaultOwner { get; set; }

        /// <summary>
        /// Default repository name for git remote.
        /// </summary>
        [JsonProperty("git_remote_default_repo")]
        public string? GitRemoteDefaultRepo { get; set; }

        /// <summary>
        /// User email from git configuration.
        /// </summary>
        [JsonProperty("git_user_email")]
        public string? GitUserEmail { get; set; }

        /// <summary>
        /// User&apos;s name from git configuration. (not GitHub username)
        /// </summary>
        [JsonProperty("git_user_name")]
        public string? GitUserName { get; set; }

        /// <summary>
        /// Remote hostname.
        /// </summary>
        [JsonProperty("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Unique identifier for each event.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Type of interaction.
        /// </summary>
        [JsonProperty("interaction_type")]
        public InteractionType InteractionType { get; set; } = default!;

        /// <summary>
        /// The last step of the event.
        /// </summary>
        [JsonProperty("last_step")]
        public string? LastStep { get; set; }

        /// <summary>
        /// The checksum of the lint report.
        /// </summary>
        [JsonProperty("lint_report_digest")]
        public string? LintReportDigest { get; set; }

        /// <summary>
        /// The number of errors in the lint report.
        /// </summary>
        [JsonProperty("lint_report_error_count")]
        public long? LintReportErrorCount { get; set; }

        /// <summary>
        /// The number of info messages in the lint report.
        /// </summary>
        [JsonProperty("lint_report_info_count")]
        public long? LintReportInfoCount { get; set; }

        /// <summary>
        /// The number of warnings in the lint report.
        /// </summary>
        [JsonProperty("lint_report_warning_count")]
        public long? LintReportWarningCount { get; set; }

        /// <summary>
        /// Timestamp when the event completed, in local time.
        /// </summary>
        [JsonProperty("local_completed_at")]
        public DateTime? LocalCompletedAt { get; set; }

        /// <summary>
        /// Timestamp when the event started, in local time.
        /// </summary>
        [JsonProperty("local_started_at")]
        public DateTime LocalStartedAt { get; set; } = default!;

        /// <summary>
        /// Checksum of the currently Rendered OpenAPI document.
        /// </summary>
        [JsonProperty("management_doc_checksum")]
        public string? ManagementDocChecksum { get; set; }

        /// <summary>
        /// Version taken from info.version field of the Rendered OpenAPI document.
        /// </summary>
        [JsonProperty("management_doc_version")]
        public string? ManagementDocVersion { get; set; }

        /// <summary>
        /// Mermaid diagram
        /// </summary>
        [JsonProperty("mermaid_diagram")]
        public string? MermaidDiagram { get; set; }

        /// <summary>
        /// The blob digest of the base source.
        /// </summary>
        [JsonProperty("openapi_diff_base_source_blob_digest")]
        public string? OpenapiDiffBaseSourceBlobDigest { get; set; }

        /// <summary>
        /// The namespace name of the base source.
        /// </summary>
        [JsonProperty("openapi_diff_base_source_namespace_name")]
        public string? OpenapiDiffBaseSourceNamespaceName { get; set; }

        /// <summary>
        /// The revision digest of the base source.
        /// </summary>
        [JsonProperty("openapi_diff_base_source_revision_digest")]
        public string? OpenapiDiffBaseSourceRevisionDigest { get; set; }

        /// <summary>
        /// The number of breaking changes in the openapi diff report.
        /// </summary>
        [JsonProperty("openapi_diff_breaking_changes_count")]
        public long? OpenapiDiffBreakingChangesCount { get; set; }

        /// <summary>
        /// Bump type of the lock file (calculated semver delta, or a custom change (manual release))
        /// </summary>
        [JsonProperty("openapi_diff_bump_type")]
        public OpenapiDiffBumpType? OpenapiDiffBumpType { get; set; }

        /// <summary>
        /// The checksum of the openapi diff report.
        /// </summary>
        [JsonProperty("openapi_diff_report_digest")]
        public string? OpenapiDiffReportDigest { get; set; }

        /// <summary>
        /// Name of the published package.
        /// </summary>
        [JsonProperty("publish_package_name")]
        public string? PublishPackageName { get; set; }

        /// <summary>
        /// Name of the registry where the package was published.
        /// </summary>
        [JsonProperty("publish_package_registry_name")]
        public string? PublishPackageRegistryName { get; set; }

        /// <summary>
        /// URL of the published package.
        /// </summary>
        [JsonProperty("publish_package_url")]
        public string? PublishPackageUrl { get; set; }

        /// <summary>
        /// Version of the published package.
        /// </summary>
        [JsonProperty("publish_package_version")]
        public string? PublishPackageVersion { get; set; }

        /// <summary>
        /// Full CLI command.
        /// </summary>
        [JsonProperty("raw_command")]
        public string? RawCommand { get; set; }

        /// <summary>
        /// Label of the git repository.
        /// </summary>
        [JsonProperty("repo_label")]
        public string? RepoLabel { get; set; }

        /// <summary>
        /// The blob digest of the source.
        /// </summary>
        [JsonProperty("source_blob_digest")]
        public string? SourceBlobDigest { get; set; }

        /// <summary>
        /// The namespace name of the source.
        /// </summary>
        [JsonProperty("source_namespace_name")]
        public string? SourceNamespaceName { get; set; }

        /// <summary>
        /// The revision digest of the source.
        /// </summary>
        [JsonProperty("source_revision_digest")]
        public string? SourceRevisionDigest { get; set; }

        /// <summary>
        /// Identifier of the Speakeasy API key.
        /// </summary>
        [JsonProperty("speakeasy_api_key_name")]
        public string SpeakeasyApiKeyName { get; set; } = default!;

        /// <summary>
        /// Version of the Speakeasy CLI.
        /// </summary>
        [JsonProperty("speakeasy_version")]
        public string SpeakeasyVersion { get; set; } = default!;

        /// <summary>
        /// Indicates whether the event was successful.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Workflow lock file (post execution)
        /// </summary>
        [JsonProperty("workflow_lock_post_raw")]
        public string? WorkflowLockPostRaw { get; set; }

        /// <summary>
        /// Workflow lock file (prior to execution)
        /// </summary>
        [JsonProperty("workflow_lock_pre_raw")]
        public string? WorkflowLockPreRaw { get; set; }

        /// <summary>
        /// Workflow file (post execution)
        /// </summary>
        [JsonProperty("workflow_post_raw")]
        public string? WorkflowPostRaw { get; set; }

        /// <summary>
        /// Workflow file (prior to execution)
        /// </summary>
        [JsonProperty("workflow_pre_raw")]
        public string? WorkflowPreRaw { get; set; }

        /// <summary>
        /// Identifier of the workspace.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; } = default!;
    }
}