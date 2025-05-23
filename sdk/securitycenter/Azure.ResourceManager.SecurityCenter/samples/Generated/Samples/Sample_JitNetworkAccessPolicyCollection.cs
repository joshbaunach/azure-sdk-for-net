// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_JitNetworkAccessPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateJITNetworkAccessPolicy()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/CreateJitNetworkAccessPolicy_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this JitNetworkAccessPolicyResource
            AzureLocation ascLocation = new AzureLocation("westeurope");
            JitNetworkAccessPolicyCollection collection = resourceGroupResource.GetJitNetworkAccessPolicies(ascLocation);

            // invoke the operation
            string jitNetworkAccessPolicyName = "default";
            JitNetworkAccessPolicyData data = new JitNetworkAccessPolicyData(new JitNetworkAccessPolicyVirtualMachine[]
            {
new JitNetworkAccessPolicyVirtualMachine(new ResourceIdentifier("/subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg1/providers/Microsoft.Compute/virtualMachines/vm1"), new JitNetworkAccessPortRule[]
{
new JitNetworkAccessPortRule(22, JitNetworkAccessPortProtocol.All, XmlConvert.ToTimeSpan("PT3H"))
{
AllowedSourceAddressPrefix = "*",
},
new JitNetworkAccessPortRule(3389, JitNetworkAccessPortProtocol.All, XmlConvert.ToTimeSpan("PT3H"))
{
AllowedSourceAddressPrefix = "*",
}
})
            })
            {
                Requests = {new JitNetworkAccessRequestInfo(new JitNetworkAccessRequestVirtualMachine[]
{
new JitNetworkAccessRequestVirtualMachine(new ResourceIdentifier("/subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg1/providers/Microsoft.Compute/virtualMachines/vm1"), new JitNetworkAccessRequestPort[]
{
new JitNetworkAccessRequestPort(3389, DateTimeOffset.Parse("2018-05-17T09:06:45.5691611Z"), JitNetworkAccessPortStatus.Initiated, JitNetworkAccessPortStatusReason.UserRequested)
{
AllowedSourceAddressPrefix = "192.127.0.2",
}
})
}, DateTimeOffset.Parse("2018-05-17T08:06:45.5691611Z"), "barbara@contoso.com")},
                Kind = "Basic",
            };
            ArmOperation<JitNetworkAccessPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, jitNetworkAccessPolicyName, data);
            JitNetworkAccessPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            JitNetworkAccessPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetJITNetworkAccessPolicy()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/GetJitNetworkAccessPolicy_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this JitNetworkAccessPolicyResource
            AzureLocation ascLocation = new AzureLocation("westeurope");
            JitNetworkAccessPolicyCollection collection = resourceGroupResource.GetJitNetworkAccessPolicies(ascLocation);

            // invoke the operation
            string jitNetworkAccessPolicyName = "default";
            JitNetworkAccessPolicyResource result = await collection.GetAsync(jitNetworkAccessPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            JitNetworkAccessPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetJITNetworkAccessPoliciesOnAResourceGroupFromASecurityDataLocation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/GetJitNetworkAccessPoliciesResourceGroupLocation_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_ListByResourceGroupAndRegion" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this JitNetworkAccessPolicyResource
            AzureLocation ascLocation = new AzureLocation("westeurope");
            JitNetworkAccessPolicyCollection collection = resourceGroupResource.GetJitNetworkAccessPolicies(ascLocation);

            // invoke the operation and iterate over the result
            await foreach (JitNetworkAccessPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                JitNetworkAccessPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetJITNetworkAccessPolicy()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/GetJitNetworkAccessPolicy_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this JitNetworkAccessPolicyResource
            AzureLocation ascLocation = new AzureLocation("westeurope");
            JitNetworkAccessPolicyCollection collection = resourceGroupResource.GetJitNetworkAccessPolicies(ascLocation);

            // invoke the operation
            string jitNetworkAccessPolicyName = "default";
            bool result = await collection.ExistsAsync(jitNetworkAccessPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetJITNetworkAccessPolicy()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2020-01-01/examples/JitNetworkAccessPolicies/GetJitNetworkAccessPolicy_example.json
            // this example is just showing the usage of "JitNetworkAccessPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this JitNetworkAccessPolicyResource
            AzureLocation ascLocation = new AzureLocation("westeurope");
            JitNetworkAccessPolicyCollection collection = resourceGroupResource.GetJitNetworkAccessPolicies(ascLocation);

            // invoke the operation
            string jitNetworkAccessPolicyName = "default";
            NullableResponse<JitNetworkAccessPolicyResource> response = await collection.GetIfExistsAsync(jitNetworkAccessPolicyName);
            JitNetworkAccessPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                JitNetworkAccessPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
