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

    public partial class BpmnModel
    {
        /// <summary>
        /// Initializes a new instance of the BpmnModel class.
        /// </summary>
        public BpmnModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BpmnModel class.
        /// </summary>
        public BpmnModel(IDictionary<string, IList<ExtensionAttribute>> definitionsAttributes = default(IDictionary<string, IList<ExtensionAttribute>>), IList<Process> processes = default(IList<Process>), IDictionary<string, GraphicInfo> locationMap = default(IDictionary<string, GraphicInfo>), IDictionary<string, GraphicInfo> labelLocationMap = default(IDictionary<string, GraphicInfo>), IDictionary<string, IList<GraphicInfo>> flowLocationMap = default(IDictionary<string, IList<GraphicInfo>>), IList<Signal> signals = default(IList<Signal>), IList<Pool> pools = default(IList<Pool>), IList<Import> imports = default(IList<Import>), IList<InterfaceModel> interfaces = default(IList<InterfaceModel>), IList<Artifact> globalArtifacts = default(IList<Artifact>), IList<Resource> resources = default(IList<Resource>), string targetNamespace = default(string), string sourceSystemId = default(string), IList<string> userTaskFormTypes = default(IList<string>), IList<string> startEventFormTypes = default(IList<string>), IDictionary<string, string> errors = default(IDictionary<string, string>), IList<Message> messages = default(IList<Message>), IDictionary<string, ItemDefinition> itemDefinitions = default(IDictionary<string, ItemDefinition>), Process mainProcess = default(Process), IDictionary<string, MessageFlow> messageFlows = default(IDictionary<string, MessageFlow>), IDictionary<string, DataStore> dataStores = default(IDictionary<string, DataStore>), IDictionary<string, string> namespaces = default(IDictionary<string, string>))
        {
            DefinitionsAttributes = definitionsAttributes;
            Processes = processes;
            LocationMap = locationMap;
            LabelLocationMap = labelLocationMap;
            FlowLocationMap = flowLocationMap;
            Signals = signals;
            Pools = pools;
            Imports = imports;
            Interfaces = interfaces;
            GlobalArtifacts = globalArtifacts;
            Resources = resources;
            TargetNamespace = targetNamespace;
            SourceSystemId = sourceSystemId;
            UserTaskFormTypes = userTaskFormTypes;
            StartEventFormTypes = startEventFormTypes;
            Errors = errors;
            Messages = messages;
            ItemDefinitions = itemDefinitions;
            MainProcess = mainProcess;
            MessageFlows = messageFlows;
            DataStores = dataStores;
            Namespaces = namespaces;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "definitionsAttributes")]
        public IDictionary<string, IList<ExtensionAttribute>> DefinitionsAttributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processes")]
        public IList<Process> Processes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locationMap")]
        public IDictionary<string, GraphicInfo> LocationMap { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "labelLocationMap")]
        public IDictionary<string, GraphicInfo> LabelLocationMap { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flowLocationMap")]
        public IDictionary<string, IList<GraphicInfo>> FlowLocationMap { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signals")]
        public IList<Signal> Signals { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pools")]
        public IList<Pool> Pools { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "imports")]
        public IList<Import> Imports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "interfaces")]
        public IList<InterfaceModel> Interfaces { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "globalArtifacts")]
        public IList<Artifact> GlobalArtifacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<Resource> Resources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetNamespace")]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceSystemId")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userTaskFormTypes")]
        public IList<string> UserTaskFormTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startEventFormTypes")]
        public IList<string> StartEventFormTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IDictionary<string, string> Errors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public IList<Message> Messages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemDefinitions")]
        public IDictionary<string, ItemDefinition> ItemDefinitions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mainProcess")]
        public Process MainProcess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageFlows")]
        public IDictionary<string, MessageFlow> MessageFlows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataStores")]
        public IDictionary<string, DataStore> DataStores { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespaces")]
        public IDictionary<string, string> Namespaces { get; set; }

    }
}