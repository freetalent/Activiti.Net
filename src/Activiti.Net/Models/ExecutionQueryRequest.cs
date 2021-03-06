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

    public partial class ExecutionQueryRequest
    {
        /// <summary>
        /// Initializes a new instance of the ExecutionQueryRequest class.
        /// </summary>
        public ExecutionQueryRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecutionQueryRequest class.
        /// </summary>
        public ExecutionQueryRequest(int? start = default(int?), int? size = default(int?), string sort = default(string), string order = default(string), string id = default(string), string activityId = default(string), string parentId = default(string), string processInstanceId = default(string), string processBusinessKey = default(string), string processDefinitionId = default(string), string processDefinitionKey = default(string), string signalEventSubscriptionName = default(string), string messageEventSubscriptionName = default(string), IList<QueryVariable> variables = default(IList<QueryVariable>), IList<QueryVariable> processInstanceVariables = default(IList<QueryVariable>), string tenantId = default(string), string tenantIdLike = default(string), bool? withoutTenantId = default(bool?))
        {
            Start = start;
            Size = size;
            Sort = sort;
            Order = order;
            Id = id;
            ActivityId = activityId;
            ParentId = parentId;
            ProcessInstanceId = processInstanceId;
            ProcessBusinessKey = processBusinessKey;
            ProcessDefinitionId = processDefinitionId;
            ProcessDefinitionKey = processDefinitionKey;
            SignalEventSubscriptionName = signalEventSubscriptionName;
            MessageEventSubscriptionName = messageEventSubscriptionName;
            Variables = variables;
            ProcessInstanceVariables = processInstanceVariables;
            TenantId = tenantId;
            TenantIdLike = tenantIdLike;
            WithoutTenantId = withoutTenantId;
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
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }

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
        [JsonProperty(PropertyName = "processDefinitionId")]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processDefinitionKey")]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signalEventSubscriptionName")]
        public string SignalEventSubscriptionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageEventSubscriptionName")]
        public string MessageEventSubscriptionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "variables")]
        public IList<QueryVariable> Variables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processInstanceVariables")]
        public IList<QueryVariable> ProcessInstanceVariables { get; set; }

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

    }
}
