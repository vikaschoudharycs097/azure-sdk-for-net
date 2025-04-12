using System;
using Azure.Identity;
using Azure.AI.Projects;
using NUnit.Framework;
using System.Threading.Tasks;
using Azure.AI.Inference;
using Azure.Core.TestFramework;

namespace Azure.AI.Projects.OneDP.Tests
{
    public class Sample_Datasets : SamplesBase<AIProjectsTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void Datasets()
        {
            #region Snippet:Datasets_CreateClient
#if SNIPPET
            string endpoint = Environment.GetEnvironmentVariable("PROJECT_ENDPOINT");
            string datasetName = Environment.GetEnvironmentVariable("DATASET_NAME");
#else
            // For testing purposes, replace with your own values.
            string endpoint = "your-project-endpoint";
            string datasetName = "your-dataset-name";
#endif
            var projectClient = new AIProjectClient(endpoint, new DefaultAzureCredential());
            #endregion

            try
            {
                #region Snippet:Datasets_UploadFileAndCreate
                Console.WriteLine("Uploading a single file to create Dataset version '1'...");
                DatasetVersion dataset = projectClient.Datasets.UploadFileAndCreate(
                    name: datasetName,
                    version: "1",
                    file: "sample_folder/file1.txt"
                );
                Console.WriteLine(dataset);
                #endregion

                #region Snippet:Datasets_UploadFolderAndCreate
                Console.WriteLine("Uploading folder to create Dataset version '2'...");
                dataset = projectClient.Datasets.UploadFolderAndCreate(
                    name: datasetName,
                    version: "2",
                    folder: "sample_folder"
                );
                Console.WriteLine(dataset);
                #endregion

                #region Snippet:Datasets_UploadAutoIncrement
                Console.WriteLine("Uploading a file to update Dataset with auto-incremented version...");
                dataset = projectClient.Datasets.UploadFileAndCreate(
                    name: datasetName,
                    file: "sample_folder/file2.txt"
                );
                Console.WriteLine(dataset);
                #endregion

                #region Snippet:Datasets_GetVersion
                Console.WriteLine("Retrieving Dataset version '1'...");
                dataset = projectClient.Datasets.GetVersion(name: datasetName, version: "1");
                Console.WriteLine(dataset);
                #endregion

                #region Snippet:Datasets_ListVersions
                Console.WriteLine($"Listing all versions for Dataset '{datasetName}':");
                foreach (var ds in projectClient.Datasets.ListVersions(name: datasetName))
                {
                    Console.WriteLine(ds);
                }
                #endregion

                #region Snippet:Datasets_ListLatest
                Console.WriteLine("Listing latest versions of all Datasets:");
                foreach (var ds in projectClient.Datasets.ListLatest())
                {
                    Console.WriteLine(ds);
                }
                #endregion

                #region Snippet:Datasets_DeleteVersions
                Console.WriteLine("Deleting Dataset versions '1', '2' and '3'...");
                projectClient.Datasets.DeleteVersion(name: datasetName, version: "1");
                projectClient.Datasets.DeleteVersion(name: datasetName, version: "2");
                projectClient.Datasets.DeleteVersion(name: datasetName, version: "3");
                #endregion
            }
            finally
            {
                projectClient.Dispose();
            }
        }
    }
}
