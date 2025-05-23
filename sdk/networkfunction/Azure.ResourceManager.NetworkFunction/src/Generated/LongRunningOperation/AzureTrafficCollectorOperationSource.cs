// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NetworkFunction
{
    internal class AzureTrafficCollectorOperationSource : IOperationSource<AzureTrafficCollectorResource>
    {
        private readonly ArmClient _client;

        internal AzureTrafficCollectorOperationSource(ArmClient client)
        {
            _client = client;
        }

        AzureTrafficCollectorResource IOperationSource<AzureTrafficCollectorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AzureTrafficCollectorData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkFunctionContext.Default);
            return new AzureTrafficCollectorResource(_client, data);
        }

        async ValueTask<AzureTrafficCollectorResource> IOperationSource<AzureTrafficCollectorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AzureTrafficCollectorData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkFunctionContext.Default);
            return await Task.FromResult(new AzureTrafficCollectorResource(_client, data)).ConfigureAwait(false);
        }
    }
}
