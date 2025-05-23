// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ContainerRegistryRunCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RunsGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/RunsGet.json
            // this example is just showing the usage of "Runs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryRunResource
            ContainerRegistryRunCollection collection = containerRegistry.GetContainerRegistryRuns();

            // invoke the operation
            string runId = "0accec26-d6de-4757-8e74-d080f38eaaab";
            ContainerRegistryRunResource result = await collection.GetAsync(runId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_RunsList()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/RunsList.json
            // this example is just showing the usage of "Runs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryRunResource
            ContainerRegistryRunCollection collection = containerRegistry.GetContainerRegistryRuns();

            // invoke the operation and iterate over the result
            string filter = "";
            int? top = 10;
            await foreach (ContainerRegistryRunResource item in collection.GetAllAsync(filter: filter, top: top))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryRunData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_RunsGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/RunsGet.json
            // this example is just showing the usage of "Runs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryRunResource
            ContainerRegistryRunCollection collection = containerRegistry.GetContainerRegistryRuns();

            // invoke the operation
            string runId = "0accec26-d6de-4757-8e74-d080f38eaaab";
            bool result = await collection.ExistsAsync(runId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_RunsGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/RunsGet.json
            // this example is just showing the usage of "Runs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryRunResource
            ContainerRegistryRunCollection collection = containerRegistry.GetContainerRegistryRuns();

            // invoke the operation
            string runId = "0accec26-d6de-4757-8e74-d080f38eaaab";
            NullableResponse<ContainerRegistryRunResource> response = await collection.GetIfExistsAsync(runId);
            ContainerRegistryRunResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryRunData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
