// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System.Linq;

    /// <summary>
    /// The swagger 2.0 schema describing a single service input or output.
    /// See Swagger specification: http://swagger.io/specification/
    /// </summary>
    public partial class TableSpecification
    {
        /// <summary>
        /// Initializes a new instance of the TableSpecification class.
        /// </summary>
        public TableSpecification() { }

        /// <summary>
        /// Initializes a new instance of the TableSpecification class.
        /// </summary>
        /// <param name="type">The type of the entity described in
        /// swagger.</param>
        /// <param name="title">Swagger schema title.</param>
        /// <param name="description">Swagger schema description.</param>
        /// <param name="format">The format, if 'type' is not 'object'</param>
        /// <param name="properties">The set of columns within the data
        /// table.</param>
        public TableSpecification(string type, string title = default(string), string description = default(string), string format = default(string), System.Collections.Generic.IDictionary<string, ColumnSpecification> properties = default(System.Collections.Generic.IDictionary<string, ColumnSpecification>))
        {
            Title = title;
            Description = description;
            Type = type;
            Format = format;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets swagger schema title.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets swagger schema description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the entity described in swagger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the format, if 'type' is not 'object'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the set of columns within the data table.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.IDictionary<string, ColumnSpecification> Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Type");
            }
            if (this.Properties != null)
            {
                foreach (var valueElement in this.Properties.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}
