// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Azure.Storage.Blobs;
using Azure.AI.Projects.OneDP;

namespace Azure.AI.Projects.Custom.Datasets
{
    internal class DatasetOperations
    {
        private (BlobContainerClient, string) CreateDatasetAndGetContainerClient(
            string name,
            string inputVersion = null)
        {
            PendingUploadResponse pendingUploadResponse;
            string outputVersion;

            if (!string.IsNullOrEmpty(inputVersion))
            {
                pendingUploadResponse = StartPendingUploadVersion(
                    name,
                    inputVersion,
                    new PendingUploadRequest(PendingUploadType.TemporaryBlobReference)
                );
                outputVersion = inputVersion;
            }
            else
            {
                pendingUploadResponse = StartPendingUpload(
                    name,
                    new PendingUploadRequest(PendingUploadType.TemporaryBlobReference)
                );
                outputVersion = pendingUploadResponse.DatasetVersion ?? throw new InvalidOperationException("Dataset version is missing in the response.");
            }

            if (pendingUploadResponse.BlobReferenceForConsumption == null ||
                string.IsNullOrEmpty(pendingUploadResponse.BlobReferenceForConsumption.BlobUri) ||
                pendingUploadResponse.BlobReferenceForConsumption.Credential?.Type != CredentialType.Sas)
            {
                throw new InvalidOperationException("Invalid blob reference or credentials.");
            }

            var containerClient = new BlobContainerClient(new Uri(pendingUploadResponse.BlobReferenceForConsumption.BlobUri));
            return (containerClient, outputVersion);
        }

        public DatasetVersion UploadFileAndCreate(string name, string version, string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new ArgumentException("The provided file does not exist.");
            }

            var (containerClient, outputVersion) = CreateDatasetAndGetContainerClient(name, version);

            using (var fileStream = File.OpenRead(filePath))
            {
                var blobName = Path.GetFileName(filePath);
                var blobClient = containerClient.GetBlobClient(blobName);
                blobClient.Upload(fileStream, overwrite: true);

                return CreateVersion(
                    name,
                    outputVersion,
                    new DatasetVersion
                    {
                        DatasetUri = blobClient.Uri.ToString(),
                        Type = DatasetType.UriFile
                    }
                );
            }
        }

        public DatasetVersion UploadFolderAndCreate(string name, string version, string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                throw new ArgumentException("The provided folder does not exist.");
            }

            var (containerClient, outputVersion) = CreateDatasetAndGetContainerClient(name, version);

            var files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
            if (!files.Any())
            {
                throw new ArgumentException("The provided folder is empty.");
            }

            foreach (var file in files)
            {
                var relativePath = Path.GetRelativePath(folderPath, file);
                using (var fileStream = File.OpenRead(file))
                {
                    var blobClient = containerClient.GetBlobClient(relativePath);
                    blobClient.Upload(fileStream, overwrite: true);
                }
            }

            return CreateVersion(
                name,
                outputVersion,
                new DatasetVersion
                {
                    DatasetUri = containerClient.Uri.ToString(),
                    Type = DatasetType.UriFolder
                }
            );
        }

        // Implement missing methods
        private PendingUploadResponse StartPendingUpload(string name, PendingUploadRequest request)
        {
            // Simulate a response for demonstration purposes
            return new PendingUploadResponse
            {
                DatasetVersion = "1.0",
                BlobReferenceForConsumption = new BlobReference
                {
                    BlobUri = "https://example.blob.core.windows.net/container",
                    Credential = new Credential { Type = CredentialType.Sas }
                }
            };
        }

        private PendingUploadResponse StartPendingUploadVersion(string name, string version, PendingUploadRequest request)
        {
            // Simulate a response for demonstration purposes
            return new PendingUploadResponse
            {
                DatasetVersion = version,
                BlobReferenceForConsumption = new BlobReference
                {
                    BlobUri = "https://example.blob.core.windows.net/container",
                    Credential = new Credential { Type = CredentialType.Sas }
                }
            };
        }

        private DatasetVersion CreateVersion(string name, string version, DatasetVersion datasetVersion)
        {
            // Simulate a response for demonstration purposes
            return new DatasetVersion
            {
                DatasetUri = datasetVersion.DatasetUri,
                Type = datasetVersion.Type
            };
        }
    }
}
