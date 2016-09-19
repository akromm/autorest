// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using System.Linq;

    public partial class CatalogArrayInner
    {
        /// <summary>
        /// Initializes a new instance of the CatalogArrayInner class.
        /// </summary>
        public CatalogArrayInner() { }

        /// <summary>
        /// Initializes a new instance of the CatalogArrayInner class.
        /// </summary>
        /// <param name="productArray">Array of products</param>
        public CatalogArrayInner(System.Collections.Generic.IList<ProductInner> productArray = default(System.Collections.Generic.IList<ProductInner>))
        {
            ProductArray = productArray;
        }

        /// <summary>
        /// Gets or sets array of products
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "productArray")]
        public System.Collections.Generic.IList<ProductInner> ProductArray { get; set; }

    }
}
