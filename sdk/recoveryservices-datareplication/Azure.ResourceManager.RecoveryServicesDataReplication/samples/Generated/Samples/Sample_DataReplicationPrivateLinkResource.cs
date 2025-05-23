// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Samples
{
    public partial class Sample_DataReplicationPrivateLinkResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPrivateLinkResource()
        {
            // Generated from example definition: 2024-09-01/PrivateLinkResource_Get.json
            // this example is just showing the usage of "PrivateLinkResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationPrivateLinkResource created on azure
            // for more information of creating DataReplicationPrivateLinkResource, please refer to the document of DataReplicationPrivateLinkResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgswagger_2024-09-01";
            string vaultName = "4";
            string privateLinkResourceName = "d";
            ResourceIdentifier dataReplicationPrivateLinkResourceId = DataReplicationPrivateLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, privateLinkResourceName);
            DataReplicationPrivateLinkResource dataReplicationPrivateLinkResource = client.GetDataReplicationPrivateLinkResource(dataReplicationPrivateLinkResourceId);

            // invoke the operation
            DataReplicationPrivateLinkResource result = await dataReplicationPrivateLinkResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
