// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProcessDefinitionActionRequest
    {
        /// <summary>
        /// Initializes a new instance of the ProcessDefinitionActionRequest
        /// class.
        /// </summary>
        public ProcessDefinitionActionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProcessDefinitionActionRequest
        /// class.
        /// </summary>
        /// <param name="includeProcessInstances">Whether or not to
        /// suspend/activate running process-instances for this
        /// process-definition. If omitted, the process-instances are left in
        /// the state they are</param>
        /// <param name="date">Date (ISO-8601) when the suspension/activation
        /// should be executed. If omitted, the suspend/activation is effective
        /// immediately.</param>
        public ProcessDefinitionActionRequest(string action = default(string), bool? includeProcessInstances = default(bool?), System.DateTime? date = default(System.DateTime?), string category = default(string))
        {
            Action = action;
            IncludeProcessInstances = includeProcessInstances;
            Date = date;
            Category = category;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets whether or not to suspend/activate running
        /// process-instances for this process-definition. If omitted, the
        /// process-instances are left in the state they are
        /// </summary>
        [JsonProperty(PropertyName = "includeProcessInstances")]
        public bool? IncludeProcessInstances { get; set; }

        /// <summary>
        /// Gets or sets date (ISO-8601) when the suspension/activation should
        /// be executed. If omitted, the suspend/activation is effective
        /// immediately.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

    }
}
