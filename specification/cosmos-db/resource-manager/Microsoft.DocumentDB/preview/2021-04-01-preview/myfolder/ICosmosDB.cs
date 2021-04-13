// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Services
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Azure Cosmos DB Database Service Resource Provider REST API
    /// </summary>
    public partial interface ICosmosDB : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// The API version to use for this operation.
        /// </summary>
        string ApiVersion { get; set; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        string SubscriptionId { get; set; }


        /// <summary>
        /// Gets the IService.
        /// </summary>
        IService Service { get; }

    }
}
