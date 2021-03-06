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

    public partial class DataStore
    {
        /// <summary>
        /// Initializes a new instance of the DataStore class.
        /// </summary>
        public DataStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataStore class.
        /// </summary>
        public DataStore(string id = default(string), int? xmlRowNumber = default(int?), int? xmlColumnNumber = default(int?), IDictionary<string, IList<ExtensionElement>> extensionElements = default(IDictionary<string, IList<ExtensionElement>>), IDictionary<string, IList<ExtensionAttribute>> attributes = default(IDictionary<string, IList<ExtensionAttribute>>), string name = default(string), string dataState = default(string), string itemSubjectRef = default(string))
        {
            Id = id;
            XmlRowNumber = xmlRowNumber;
            XmlColumnNumber = xmlColumnNumber;
            ExtensionElements = extensionElements;
            Attributes = attributes;
            Name = name;
            DataState = dataState;
            ItemSubjectRef = itemSubjectRef;
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
        [JsonProperty(PropertyName = "dataState")]
        public string DataState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemSubjectRef")]
        public string ItemSubjectRef { get; set; }

    }
}
