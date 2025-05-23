// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientConnectionHealthDetail : IUtf8JsonSerializable, IJsonModel<VpnClientConnectionHealthDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnClientConnectionHealthDetail>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VpnClientConnectionHealthDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConnectionHealthDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnClientConnectionHealthDetail)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(VpnConnectionId))
            {
                writer.WritePropertyName("vpnConnectionId"u8);
                writer.WriteStringValue(VpnConnectionId);
            }
            if (options.Format != "W" && Optional.IsDefined(VpnConnectionDurationInSeconds))
            {
                writer.WritePropertyName("vpnConnectionDuration"u8);
                writer.WriteNumberValue(VpnConnectionDurationInSeconds.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(VpnConnectionOn))
            {
                writer.WritePropertyName("vpnConnectionTime"u8);
                writer.WriteStringValue(VpnConnectionOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PublicIPAddress))
            {
                writer.WritePropertyName("publicIpAddress"u8);
                writer.WriteStringValue(PublicIPAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIpAddress"u8);
                writer.WriteStringValue(PrivateIPAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(VpnUserName))
            {
                writer.WritePropertyName("vpnUserName"u8);
                writer.WriteStringValue(VpnUserName);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxBandwidth))
            {
                writer.WritePropertyName("maxBandwidth"u8);
                writer.WriteNumberValue(MaxBandwidth.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EgressPacketsTransferred))
            {
                writer.WritePropertyName("egressPacketsTransferred"u8);
                writer.WriteNumberValue(EgressPacketsTransferred.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EgressBytesTransferred))
            {
                writer.WritePropertyName("egressBytesTransferred"u8);
                writer.WriteNumberValue(EgressBytesTransferred.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IngressPacketsTransferred))
            {
                writer.WritePropertyName("ingressPacketsTransferred"u8);
                writer.WriteNumberValue(IngressPacketsTransferred.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IngressBytesTransferred))
            {
                writer.WritePropertyName("ingressBytesTransferred"u8);
                writer.WriteNumberValue(IngressBytesTransferred.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxPacketsPerSecond))
            {
                writer.WritePropertyName("maxPacketsPerSecond"u8);
                writer.WriteNumberValue(MaxPacketsPerSecond.Value);
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

        VpnClientConnectionHealthDetail IJsonModel<VpnClientConnectionHealthDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConnectionHealthDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnClientConnectionHealthDetail)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnClientConnectionHealthDetail(document.RootElement, options);
        }

        internal static VpnClientConnectionHealthDetail DeserializeVpnClientConnectionHealthDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vpnConnectionId = default;
            long? vpnConnectionDuration = default;
            DateTimeOffset? vpnConnectionTime = default;
            string publicIPAddress = default;
            string privateIPAddress = default;
            string vpnUserName = default;
            long? maxBandwidth = default;
            long? egressPacketsTransferred = default;
            long? egressBytesTransferred = default;
            long? ingressPacketsTransferred = default;
            long? ingressBytesTransferred = default;
            long? maxPacketsPerSecond = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vpnConnectionId"u8))
                {
                    vpnConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vpnConnectionDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vpnConnectionDuration = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vpnConnectionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vpnConnectionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("publicIpAddress"u8))
                {
                    publicIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vpnUserName"u8))
                {
                    vpnUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxBandwidth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBandwidth = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("egressPacketsTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressPacketsTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("egressBytesTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("ingressPacketsTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingressPacketsTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("ingressBytesTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingressBytesTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxPacketsPerSecond"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPacketsPerSecond = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VpnClientConnectionHealthDetail(
                vpnConnectionId,
                vpnConnectionDuration,
                vpnConnectionTime,
                publicIPAddress,
                privateIPAddress,
                vpnUserName,
                maxBandwidth,
                egressPacketsTransferred,
                egressBytesTransferred,
                ingressPacketsTransferred,
                ingressBytesTransferred,
                maxPacketsPerSecond,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnClientConnectionHealthDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConnectionHealthDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VpnClientConnectionHealthDetail)} does not support writing '{options.Format}' format.");
            }
        }

        VpnClientConnectionHealthDetail IPersistableModel<VpnClientConnectionHealthDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientConnectionHealthDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVpnClientConnectionHealthDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnClientConnectionHealthDetail)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnClientConnectionHealthDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
