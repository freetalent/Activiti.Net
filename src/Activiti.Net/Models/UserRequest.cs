// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Activiti.Net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UserRequest
    {
        /// <summary>
        /// Initializes a new instance of the UserRequest class.
        /// </summary>
        public UserRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserRequest class.
        /// </summary>
        public UserRequest(string id = default(string), string firstName = default(string), string lastName = default(string), string url = default(string), string email = default(string), string pictureUrl = default(string), string password = default(string))
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Url = url;
            Email = email;
            PictureUrl = pictureUrl;
            Password = password;
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
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pictureUrl")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}
