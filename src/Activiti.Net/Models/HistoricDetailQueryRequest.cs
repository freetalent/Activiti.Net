// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class HistoricDetailQueryRequest
    {
        /// <summary>
        /// Initializes a new instance of the HistoricDetailQueryRequest class.
        /// </summary>
        public HistoricDetailQueryRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HistoricDetailQueryRequest class.
        /// </summary>
        public HistoricDetailQueryRequest(int? start = default(int?), int? size = default(int?), string sort = default(string), string order = default(string), string id = default(string), string processInstanceId = default(string), string executionId = default(string), string activityInstanceId = default(string), string taskId = default(string), bool? selectOnlyFormProperties = default(bool?), bool? selectOnlyVariableUpdates = default(bool?))
        {
            Start = start;
            Size = size;
            Sort = sort;
            Order = order;
            Id = id;
            ProcessInstanceId = processInstanceId;
            ExecutionId = executionId;
            ActivityInstanceId = activityInstanceId;
            TaskId = taskId;
            SelectOnlyFormProperties = selectOnlyFormProperties;
            SelectOnlyVariableUpdates = selectOnlyVariableUpdates;
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
        [JsonProperty(PropertyName = "processInstanceId")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executionId")]
        public string ExecutionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityInstanceId")]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "selectOnlyFormProperties")]
        public bool? SelectOnlyFormProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "selectOnlyVariableUpdates")]
        public bool? SelectOnlyVariableUpdates { get; set; }

    }
}
