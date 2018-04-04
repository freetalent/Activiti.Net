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

    public partial class Lane
    {
        /// <summary>
        /// Initializes a new instance of the Lane class.
        /// </summary>
        public Lane()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Lane class.
        /// </summary>
        public Lane(string id = default(string), int? xmlRowNumber = default(int?), int? xmlColumnNumber = default(int?), IDictionary<string, IList<ExtensionElement>> extensionElements = default(IDictionary<string, IList<ExtensionElement>>), IDictionary<string, IList<ExtensionAttribute>> attributes = default(IDictionary<string, IList<ExtensionAttribute>>), string name = default(string), Process parentProcess = default(Process), IList<string> flowReferences = default(IList<string>))
        {
            Id = id;
            XmlRowNumber = xmlRowNumber;
            XmlColumnNumber = xmlColumnNumber;
            ExtensionElements = extensionElements;
            Attributes = attributes;
            Name = name;
            ParentProcess = parentProcess;
            FlowReferences = flowReferences;
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
        [JsonProperty(PropertyName = "xmlRowNumber")]
        public int? XmlRowNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "xmlColumnNumber")]
        public int? XmlColumnNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extensionElements")]
        public IDictionary<string, IList<ExtensionElement>> ExtensionElements { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IDictionary<string, IList<ExtensionAttribute>> Attributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentProcess")]
        public Process ParentProcess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flowReferences")]
        public IList<string> FlowReferences { get; set; }

    }
}
