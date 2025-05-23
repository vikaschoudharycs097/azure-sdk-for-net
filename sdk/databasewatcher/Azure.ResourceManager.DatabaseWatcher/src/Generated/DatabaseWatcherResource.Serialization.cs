// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DatabaseWatcher
{
    public partial class DatabaseWatcherResource : IJsonModel<DatabaseWatcherData>
    {
        void IJsonModel<DatabaseWatcherData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DatabaseWatcherData>)Data).Write(writer, options);

        DatabaseWatcherData IJsonModel<DatabaseWatcherData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DatabaseWatcherData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DatabaseWatcherData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DatabaseWatcherData>(Data, options, AzureResourceManagerDatabaseWatcherContext.Default);

        DatabaseWatcherData IPersistableModel<DatabaseWatcherData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DatabaseWatcherData>(data, options, AzureResourceManagerDatabaseWatcherContext.Default);

        string IPersistableModel<DatabaseWatcherData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DatabaseWatcherData>)Data).GetFormatFromOptions(options);
    }
}
