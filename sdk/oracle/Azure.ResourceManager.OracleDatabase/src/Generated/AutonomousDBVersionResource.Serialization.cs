// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.OracleDatabase
{
    public partial class AutonomousDBVersionResource : IJsonModel<AutonomousDBVersionData>
    {
        void IJsonModel<AutonomousDBVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AutonomousDBVersionData>)Data).Write(writer, options);

        AutonomousDBVersionData IJsonModel<AutonomousDBVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AutonomousDBVersionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AutonomousDBVersionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AutonomousDBVersionData>(Data, options, AzureResourceManagerOracleDatabaseContext.Default);

        AutonomousDBVersionData IPersistableModel<AutonomousDBVersionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AutonomousDBVersionData>(data, options, AzureResourceManagerOracleDatabaseContext.Default);

        string IPersistableModel<AutonomousDBVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AutonomousDBVersionData>)Data).GetFormatFromOptions(options);
    }
}
