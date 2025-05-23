// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabGenerateUploadUriResult : IUtf8JsonSerializable, IJsonModel<DevTestLabGenerateUploadUriResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabGenerateUploadUriResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabGenerateUploadUriResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabGenerateUploadUriResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabGenerateUploadUriResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(UploadUri))
            {
                writer.WritePropertyName("uploadUri"u8);
                writer.WriteStringValue(UploadUri.AbsoluteUri);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DevTestLabGenerateUploadUriResult IJsonModel<DevTestLabGenerateUploadUriResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabGenerateUploadUriResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabGenerateUploadUriResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabGenerateUploadUriResult(document.RootElement, options);
        }

        internal static DevTestLabGenerateUploadUriResult DeserializeDevTestLabGenerateUploadUriResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri uploadUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uploadUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevTestLabGenerateUploadUriResult(uploadUri, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabGenerateUploadUriResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabGenerateUploadUriResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDevTestLabsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabGenerateUploadUriResult)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabGenerateUploadUriResult IPersistableModel<DevTestLabGenerateUploadUriResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabGenerateUploadUriResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevTestLabGenerateUploadUriResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabGenerateUploadUriResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabGenerateUploadUriResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
