//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Operations
{
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    
    public class SearchWorkspaceEventsRequest
    {

        /// <summary>
        /// A specific gen lock ID for the events.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=generate_gen_lock_id")]
        public string? GenerateGenLockId { get; set; }

        /// <summary>
        /// Specified interaction type for events.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=interaction_type")]
        public InteractionType? InteractionType { get; set; }

        /// <summary>
        /// Unique identifier of the lint report digest.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=lint_report_digest")]
        public string? LintReportDigest { get; set; }

        /// <summary>
        /// Unique identifier of the openapi diff report digest.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=openapi_diff_report_digest")]
        public string? OpenapiDiffReportDigest { get; set; }

        /// <summary>
        /// Unique identifier of the source revision digest.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=source_revision_digest")]
        public string? SourceRevisionDigest { get; set; }

        /// <summary>
        /// Unique identifier of the workspace.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=workspaceID")]
        public string? WorkspaceID { get; set; }
    }
}