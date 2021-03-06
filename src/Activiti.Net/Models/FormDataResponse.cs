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

    public partial class FormDataResponse
    {
        /// <summary>
        /// Initializes a new instance of the FormDataResponse class.
        /// </summary>
        public FormDataResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FormDataResponse class.
        /// </summary>
        public FormDataResponse(string formKey = default(string), string deploymentId = default(string), string processDefinitionId = default(string), string processDefinitionUrl = default(string), string taskId = default(string), string taskUrl = default(string), IList<RestFormProperty> formProperties = default(IList<RestFormProperty>))
        {
            FormKey = formKey;
            DeploymentId = deploymentId;
            ProcessDefinitionId = processDefinitionId;
            ProcessDefinitionUrl = processDefinitionUrl;
            TaskId = taskId;
            TaskUrl = taskUrl;
            FormProperties = formProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formKey")]
        public string FormKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deploymentId")]
        public string DeploymentId { get; set; }

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
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskUrl")]
        public string TaskUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formProperties")]
        public IList<RestFormProperty> FormProperties { get; set; }

    }
}
