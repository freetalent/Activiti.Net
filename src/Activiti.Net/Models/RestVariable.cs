// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RestVariable
    {
        /// <summary>
        /// Initializes a new instance of the RestVariable class.
        /// </summary>
        public RestVariable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestVariable class.
        /// </summary>
        public RestVariable(string name = default(string), string type = default(string), object value = default(object), string valueUrl = default(string), string scope = default(string))
        {
            Name = name;
            Type = type;
            Value = value;
            ValueUrl = valueUrl;
            Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valueUrl")]
        public string ValueUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

    }
}
