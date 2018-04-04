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

    public partial class ExecutionActionRequest
    {
        /// <summary>
        /// Initializes a new instance of the ExecutionActionRequest class.
        /// </summary>
        public ExecutionActionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecutionActionRequest class.
        /// </summary>
        public ExecutionActionRequest(string action = default(string), string signalName = default(string), string messageName = default(string), IList<RestVariable> variables = default(IList<RestVariable>), IList<RestVariable> transientVariables = default(IList<RestVariable>))
        {
            Action = action;
            SignalName = signalName;
            MessageName = messageName;
            Variables = variables;
            TransientVariables = transientVariables;
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
        /// </summary>
        [JsonProperty(PropertyName = "signalName")]
        public string SignalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageName")]
        public string MessageName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "variables")]
        public IList<RestVariable> Variables { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transientVariables")]
        public IList<RestVariable> TransientVariables { get; set; }

    }
}
