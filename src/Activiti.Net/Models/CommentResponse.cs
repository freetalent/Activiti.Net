// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CommentResponse
    {
        /// <summary>
        /// Initializes a new instance of the CommentResponse class.
        /// </summary>
        public CommentResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CommentResponse class.
        /// </summary>
        public CommentResponse(string id = default(string), string author = default(string), string message = default(string), System.DateTime? time = default(System.DateTime?), string taskId = default(string), string taskUrl = default(string), string processInstanceId = default(string), string processInstanceUrl = default(string))
        {
            Id = id;
            Author = author;
            Message = message;
            Time = time;
            TaskId = taskId;
            TaskUrl = taskUrl;
            ProcessInstanceId = processInstanceId;
            ProcessInstanceUrl = processInstanceUrl;
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
        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskUrl")]
        public string TaskUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processInstanceId")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processInstanceUrl")]
        public string ProcessInstanceUrl { get; set; }

    }
}
