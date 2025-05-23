// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class FailoverJobCustomProperties : IUtf8JsonSerializable, IJsonModel<FailoverJobCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FailoverJobCustomProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FailoverJobCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverJobCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverJobCustomProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsCollectionDefined(ProtectedItemDetails))
            {
                writer.WritePropertyName("protectedItemDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedItemDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        FailoverJobCustomProperties IJsonModel<FailoverJobCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverJobCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverJobCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFailoverJobCustomProperties(document.RootElement, options);
        }

        internal static FailoverJobCustomProperties DeserializeFailoverJobCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FailoverProtectedItemProperties> protectedItemDetails = default;
            string instanceType = default;
            AffectedObjectDetails affectedObjectDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FailoverProtectedItemProperties> array = new List<FailoverProtectedItemProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FailoverProtectedItemProperties.DeserializeFailoverProtectedItemProperties(item, options));
                    }
                    protectedItemDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    affectedObjectDetails = AffectedObjectDetails.DeserializeAffectedObjectDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FailoverJobCustomProperties(instanceType, affectedObjectDetails, serializedAdditionalRawData, protectedItemDetails ?? new ChangeTrackingList<FailoverProtectedItemProperties>());
        }

        BinaryData IPersistableModel<FailoverJobCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverJobCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FailoverJobCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        FailoverJobCustomProperties IPersistableModel<FailoverJobCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverJobCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFailoverJobCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FailoverJobCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FailoverJobCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
