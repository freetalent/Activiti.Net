// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RestIdentityLink
    {
        /// <summary>
        /// Initializes a new instance of the RestIdentityLink class.
        /// </summary>
        public RestIdentityLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestIdentityLink class.
        /// </summary>
        public RestIdentityLink(string url = default(string), string user = default(string), string group = default(string), string type = default(string))
        {
            Url = url;
            User = user;
            Group = group;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}