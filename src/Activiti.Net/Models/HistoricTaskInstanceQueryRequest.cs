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

    public partial class HistoricTaskInstanceQueryRequest
    {
        /// <summary>
        /// Initializes a new instance of the HistoricTaskInstanceQueryRequest
        /// class.
        /// </summary>
        public HistoricTaskInstanceQueryRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HistoricTaskInstanceQueryRequest
        /// class.
        /// </summary>
        public HistoricTaskInstanceQueryRequest(int? start = default(int?), int? size = default(int?), string sort = default(string), string order = default(string), string taskId = default(string), string processInstanceId = default(string), string processBusinessKey = default(string), string processBusinessKeyLike = default(string), string processDefinitionId = default(string), string processDefinitionKey = default(string), string processDefinitionKeyLike = default(string), string processDefinitionName = default(string), string processDefinitionNameLike = default(string), string executionId = default(string), string taskName = default(string), string taskNameLike = default(string), string taskDescription = default(string), string taskDescriptionLike = default(string), string taskDefinitionKey = default(string), string taskDefinitionKeyLike = default(string), string taskCategory = default(string), string taskDeleteReason = default(string), string taskDeleteReasonLike = default(string), string taskAssignee = default(string), string taskAssigneeLike = default(string), string taskOwner = default(string), string taskOwnerLike = default(string), string taskInvolvedUser = default(string), int? taskPriority = default(int?), int? taskMinPriority = default(int?), int? taskMaxPriority = default(int?), bool? finished = default(bool?), bool? processFinished = default(bool?), string parentTaskId = default(string), System.DateTime? dueDate = default(System.DateTime?), System.DateTime? dueDateAfter = default(System.DateTime?), System.DateTime? dueDateBefore = default(System.DateTime?), bool? withoutDueDate = default(bool?), System.DateTime? taskCreatedOn = default(System.DateTime?), System.DateTime? taskCreatedBefore = default(System.DateTime?), System.DateTime? taskCreatedAfter = default(System.DateTime?), System.DateTime? taskCompletedOn = default(System.DateTime?), System.DateTime? taskCompletedBefore = default(System.DateTime?), System.DateTime? taskCompletedAfter = default(System.DateTime?), bool? includeTaskLocalVariables = default(bool?), bool? includeProcessVariables = default(bool?), IList<QueryVariable> taskVariables = default(IList<QueryVariable>), IList<QueryVariable> processVariables = default(IList<QueryVariable>), string tenantId = default(string), string tenantIdLike = default(string), bool? withoutTenantId = default(bool?), string taskCandidateGroup = default(string))
        {
            Start = start;
            Size = size;
            Sort = sort;
            Order = order;
            TaskId = taskId;
            ProcessInstanceId = processInstanceId;
            ProcessBusinessKey = processBusinessKey;
            ProcessBusinessKeyLike = processBusinessKeyLike;
            ProcessDefinitionId = processDefinitionId;
            ProcessDefinitionKey = processDefinitionKey;
            ProcessDefinitionKeyLike = processDefinitionKeyLike;
            ProcessDefinitionName = processDefinitionName;
            ProcessDefinitionNameLike = processDefinitionNameLike;
            ExecutionId = executionId;
            TaskName = taskName;
            TaskNameLike = taskNameLike;
            TaskDescription = taskDescription;
            TaskDescriptionLike = taskDescriptionLike;
            TaskDefinitionKey = taskDefinitionKey;
            TaskDefinitionKeyLike = taskDefinitionKeyLike;
            TaskCategory = taskCategory;
            TaskDeleteReason = taskDeleteReason;
            TaskDeleteReasonLike = taskDeleteReasonLike;
            TaskAssignee = taskAssignee;
            TaskAssigneeLike = taskAssigneeLike;
            TaskOwner = taskOwner;
            TaskOwnerLike = taskOwnerLike;
            TaskInvolvedUser = taskInvolvedUser;
            TaskPriority = taskPriority;
            TaskMinPriority = taskMinPriority;
            TaskMaxPriority = taskMaxPriority;
            Finished = finished;
            ProcessFinished = processFinished;
            ParentTaskId = parentTaskId;
            DueDate = dueDate;
            DueDateAfter = dueDateAfter;
            DueDateBefore = dueDateBefore;
            WithoutDueDate = withoutDueDate;
            TaskCreatedOn = taskCreatedOn;
            TaskCreatedBefore = taskCreatedBefore;
            TaskCreatedAfter = taskCreatedAfter;
            TaskCompletedOn = taskCompletedOn;
            TaskCompletedBefore = taskCompletedBefore;
            TaskCompletedAfter = taskCompletedAfter;
            IncludeTaskLocalVariables = includeTaskLocalVariables;
            IncludeProcessVariables = includeProcessVariables;
            TaskVariables = taskVariables;
            ProcessVariables = processVariables;
            TenantId = tenantId;
            TenantIdLike = tenantIdLike;
            WithoutTenantId = withoutTenantId;
            TaskCandidateGroup = taskCandidateGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public int? Start { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sort")]
        public string Sort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public string Order { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processInstanceId")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processBusinessKey")]
        public string ProcessBusinessKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processBusinessKeyLike")]
        public string ProcessBusinessKeyLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processDefinitionId")]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processDefinitionKey")]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processDefinitionKeyLike")]
        public string ProcessDefinitionKeyLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processDefinitionName")]
        public string ProcessDefinitionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processDefinitionNameLike")]
        public string ProcessDefinitionNameLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executionId")]
        public string ExecutionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskName")]
        public string TaskName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskNameLike")]
        public string TaskNameLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskDescription")]
        public string TaskDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskDescriptionLike")]
        public string TaskDescriptionLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskDefinitionKey")]
        public string TaskDefinitionKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskDefinitionKeyLike")]
        public string TaskDefinitionKeyLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskCategory")]
        public string TaskCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskDeleteReason")]
        public string TaskDeleteReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskDeleteReasonLike")]
        public string TaskDeleteReasonLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskAssignee")]
        public string TaskAssignee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskAssigneeLike")]
        public string TaskAssigneeLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskOwner")]
        public string TaskOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskOwnerLike")]
        public string TaskOwnerLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskInvolvedUser")]
        public string TaskInvolvedUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskPriority")]
        public int? TaskPriority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskMinPriority")]
        public int? TaskMinPriority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskMaxPriority")]
        public int? TaskMaxPriority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "finished")]
        public bool? Finished { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processFinished")]
        public bool? ProcessFinished { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentTaskId")]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dueDate")]
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dueDateAfter")]
        public System.DateTime? DueDateAfter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dueDateBefore")]
        public System.DateTime? DueDateBefore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "withoutDueDate")]
        public bool? WithoutDueDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskCreatedOn")]
        public System.DateTime? TaskCreatedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskCreatedBefore")]
        public System.DateTime? TaskCreatedBefore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskCreatedAfter")]
        public System.DateTime? TaskCreatedAfter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskCompletedOn")]
        public System.DateTime? TaskCompletedOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskCompletedBefore")]
        public System.DateTime? TaskCompletedBefore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskCompletedAfter")]
        public System.DateTime? TaskCompletedAfter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "includeTaskLocalVariables")]
        public bool? IncludeTaskLocalVariables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "includeProcessVariables")]
        public bool? IncludeProcessVariables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskVariables")]
        public IList<QueryVariable> TaskVariables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processVariables")]
        public IList<QueryVariable> ProcessVariables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tenantIdLike")]
        public string TenantIdLike { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "withoutTenantId")]
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskCandidateGroup")]
        public string TaskCandidateGroup { get; set; }

    }
}