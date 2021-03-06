// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CommentRequest
    {
        /// <summary>
        /// Initializes a new instance of the CommentRequest class.
        /// </summary>
        public CommentRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CommentRequest class.
        /// </summary>
        public CommentRequest(string id = default(string), string url = default(string), string author = default(string), string message = default(string), string type = default(string), bool? saveProcessInstanceId = default(bool?))
        {
            Id = id;
            Url = url;
            Author = author;
            Message = message;
            Type = type;
            SaveProcessInstanceId = saveProcessInstanceId;
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
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "saveProcessInstanceId")]
        public bool? SaveProcessInstanceId { get; set; }

    }
}
