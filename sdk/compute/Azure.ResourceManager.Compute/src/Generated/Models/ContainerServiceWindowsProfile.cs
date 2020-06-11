// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Profile for Windows VMs in the container service cluster. </summary>
    public partial class ContainerServiceWindowsProfile
    {
        /// <summary> Initializes a new instance of ContainerServiceWindowsProfile. </summary>
        /// <param name="adminUsername"> The administrator username to use for Windows VMs. </param>
        /// <param name="adminPassword"> The administrator password to use for Windows VMs. </param>
        public ContainerServiceWindowsProfile(string adminUsername, string adminPassword)
        {
            if (adminUsername == null)
            {
                throw new ArgumentNullException(nameof(adminUsername));
            }
            if (adminPassword == null)
            {
                throw new ArgumentNullException(nameof(adminPassword));
            }

            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
        }

        /// <summary> The administrator username to use for Windows VMs. </summary>
        public string AdminUsername { get; set; }
        /// <summary> The administrator password to use for Windows VMs. </summary>
        public string AdminPassword { get; set; }
    }
}
