// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application gateway probe health response match. </summary>
    public partial class ApplicationGatewayProbeHealthResponseMatch
    {
        /// <summary> Initializes a new instance of ApplicationGatewayProbeHealthResponseMatch. </summary>
        public ApplicationGatewayProbeHealthResponseMatch()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayProbeHealthResponseMatch. </summary>
        /// <param name="body"> Body that must be contained in the health response. Default value is empty. </param>
        /// <param name="statusCodes"> Allowed ranges of healthy status codes. Default range of healthy status codes is 200-399. </param>
        internal ApplicationGatewayProbeHealthResponseMatch(string body, IList<string> statusCodes)
        {
            Body = body;
            StatusCodes = statusCodes;
        }

        /// <summary> Body that must be contained in the health response. Default value is empty. </summary>
        public string Body { get; set; }
        /// <summary> Allowed ranges of healthy status codes. Default range of healthy status codes is 200-399. </summary>
        public IList<string> StatusCodes { get; set; }
    }
}
