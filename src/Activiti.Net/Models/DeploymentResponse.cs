// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DeploymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentResponse class.
        /// </summary>
        public DeploymentResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentResponse class.
        /// </summary>
        public DeploymentResponse(string id = default(string), string name = default(string), System.DateTime? deploymentTime = default(System.DateTime?), string category = default(string), string url = default(string), string tenantId = default(string))
        {
            Id = id;
            Name = name;
            DeploymentTime = deploymentTime;
            Category = category;
            Url = url;
            TenantId = tenantId;
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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deploymentTime")]
        public System.DateTime? DeploymentTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

    }
}
