// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The policy definition.
    /// </summary>
    public partial class PolicyAssignment : IResource
    {
        /// <summary>
        /// Initializes a new instance of the PolicyAssignment class.
        /// </summary>
        public PolicyAssignment() { }

        /// <summary>
        /// Initializes a new instance of the PolicyAssignment class.
        /// </summary>
        public PolicyAssignment(string id = default(string), string type = default(string), string name = default(string), string displayName = default(string), string policyDefinitionId = default(string), string scope = default(string))
        {
            Id = id;
            Type = type;
            Name = name;
            DisplayName = displayName;
            PolicyDefinitionId = policyDefinitionId;
            Scope = scope;
        }

        /// <summary>
        /// Gets or sets the Id of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the policy assignment display name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the policy definition Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyDefinitionId")]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the scope at which the policy assignment exists.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; set; }

    }
}
