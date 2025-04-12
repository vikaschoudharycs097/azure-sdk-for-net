// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.AI.Projects;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Projects.OneDP.Tests;

public class Sample_Deployment : SamplesBase<AIProjectsTestEnvironment>
{
    [Test]
    [SyncOnly]
    public void DeploymentExample()
    {
        #region Snippet:DeploymentExampleSync
#if SNIPPET
        var endpoint = Environment.GetEnvironmentVariable("PROJECT_ENDPOINT");
        var deploymentName = Environment.GetEnvironmentVariable("DEPLOYMENT_NAME");
        var modelPublisher = Environment.GetEnvironmentVariable("MODEL_PUBLISHER");
#else
        var endpoint = TestEnvironment.ProjectEndpoint;
        var deploymentName = TestEnvironment.DeploymentName;
        var modelPublisher = TestEnvironment.ModelPublisher;
#endif
        var credential = new AzureKeyCredential(TestEnvironment.ProjectApiKey);
        var projectClient = new AIProjectClient(endpoint, credential);

        Console.WriteLine("List all deployments:");
        foreach (var deployment in projectClient.Deployments.List())
        {
            Console.WriteLine(deployment);
        }

        Console.WriteLine($"List all deployments by the model publisher `{modelPublisher}`:");
        foreach (var deployment in projectClient.Deployments.List(modelPublisher: modelPublisher))
        {
            Console.WriteLine(deployment);
        }

        Console.WriteLine($"Get a single deployment named `{deploymentName}`:");
        var deploymentDetails = projectClient.Deployments.Get(deploymentName);
        Console.WriteLine(deploymentDetails);
        #endregion
    }
}
