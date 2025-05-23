// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationScheduleResource : IJsonModel<AutomationScheduleData>
    {
        void IJsonModel<AutomationScheduleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AutomationScheduleData>)Data).Write(writer, options);

        AutomationScheduleData IJsonModel<AutomationScheduleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AutomationScheduleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AutomationScheduleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AutomationScheduleData>(Data, options, AzureResourceManagerAutomationContext.Default);

        AutomationScheduleData IPersistableModel<AutomationScheduleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AutomationScheduleData>(data, options, AzureResourceManagerAutomationContext.Default);

        string IPersistableModel<AutomationScheduleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AutomationScheduleData>)Data).GetFormatFromOptions(options);
    }
}
