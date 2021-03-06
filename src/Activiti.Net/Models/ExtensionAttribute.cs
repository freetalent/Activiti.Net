// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ExtensionAttribute
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionAttribute class.
        /// </summary>
        public ExtensionAttribute()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionAttribute class.
        /// </summary>
        public ExtensionAttribute(string name = default(string), string value = default(string), string namespacePrefix = default(string), string namespaceProperty = default(string))
        {
            Name = name;
            Value = value;
            NamespacePrefix = namespacePrefix;
            NamespaceProperty = namespaceProperty;
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
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespacePrefix")]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

    }
}
