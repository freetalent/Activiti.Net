// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class HistoricTaskInstanceResponse
    {
        /// <summary>
        /// Initializes a new instance of the HistoricTaskInstanceResponse
        /// class.
        /// </summary>
        public HistoricTaskInstanceResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HistoricTaskInstanceResponse
        /// class.
        /// </summary>
        public HistoricTaskInstanceResponse(string id = default(string), string processDefinitionId = default(string), string processDefinitionUrl = default(string), string processInstanceId = default(string), string processInstanceUrl = default(string), string executionId = default(string), string name = default(string), string description = default(string), string deleteReason = default(string), string owner = default(string), string assignee = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), long? durationInMillis = default(long?), long? workTimeInMillis = default(long?), System.DateTime? claimTime = default(System.DateTime?), string taskDefinitionKey = default(string), string formKey = default(string), int? priority = default(int?), System.DateTime? dueDate = default(System.DateTime?), string parentTaskId = default(string), string url = default(string), IList<RestVariable> variables = default(IList<RestVariable>), string tenantId = default(string), string category = default(string))
        {
            Id = id;
            ProcessDefinitionId = processDefinitionId;
            ProcessDefinitionUrl = processDefinitionUrl;
            ProcessInstanceId = processInstanceId;
            ProcessInstanceUrl = processInstanceUrl;
            ExecutionId = executionId;
            Name = name;
            Description = description;
            DeleteReason = deleteReason;
            Owner = owner;
            Assignee = assignee;
            StartTime = startTime;
            EndTime = endTime;
            DurationInMillis = durationInMillis;
            WorkTimeInMillis = workTimeInMillis;
            ClaimTime = claimTime;
            TaskDefinitionKey = taskDefinitionKey;
            FormKey = formKey;
            Priority = priority;
            DueDate = dueDate;
            ParentTaskId = parentTaskId;
            Url = url;
            Variables = variables;
            TenantId = tenantId;
            Category = category;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processDefinitionId")]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processDefinitionUrl")]
        public string ProcessDefinitionUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processInstanceId")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processInstanceUrl")]
        public string ProcessInstanceUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executionId")]
        public string ExecutionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deleteReason")]
        public string DeleteReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assignee")]
        public string Assignee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "durationInMillis")]
        public long? DurationInMillis { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workTimeInMillis")]
        public long? WorkTimeInMillis { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "claimTime")]
        public System.DateTime? ClaimTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskDefinitionKey")]
        public string TaskDefinitionKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formKey")]
        public string FormKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dueDate")]
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentTaskId")]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "variables")]
        public IList<RestVariable> Variables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

    }
}
