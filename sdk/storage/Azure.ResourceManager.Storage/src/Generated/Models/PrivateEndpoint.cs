// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The Private Endpoint resource. </summary>
    public partial class PrivateEndpoint
    {
        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        public PrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        /// <param name="id"> The ARM identifier for Private Endpoint. </param>
        internal PrivateEndpoint(string id)
        {
            Id = id;
        }

        /// <summary> The ARM identifier for Private Endpoint. </summary>
        public string Id { get; }
    }
}