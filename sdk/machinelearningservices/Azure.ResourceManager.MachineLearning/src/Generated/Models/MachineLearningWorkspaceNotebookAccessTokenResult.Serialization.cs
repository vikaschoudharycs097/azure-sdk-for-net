// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningWorkspaceNotebookAccessTokenResult : IUtf8JsonSerializable, IJsonModel<MachineLearningWorkspaceNotebookAccessTokenResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningWorkspaceNotebookAccessTokenResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspaceNotebookAccessTokenResult)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(NotebookResourceId))
            {
                writer.WritePropertyName("notebookResourceId"u8);
                writer.WriteStringValue(NotebookResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (options.Format != "W" && Optional.IsDefined(PublicDns))
            {
                writer.WritePropertyName("publicDns"u8);
                writer.WriteStringValue(PublicDns);
            }
            if (options.Format != "W" && Optional.IsDefined(AccessToken))
            {
                writer.WritePropertyName("accessToken"u8);
                writer.WriteStringValue(AccessToken);
            }
            if (options.Format != "W" && Optional.IsDefined(TokenType))
            {
                writer.WritePropertyName("tokenType"u8);
                writer.WriteStringValue(TokenType);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpiresIn))
            {
                writer.WritePropertyName("expiresIn"u8);
                writer.WriteNumberValue(ExpiresIn.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken"u8);
                writer.WriteStringValue(RefreshToken);
            }
            if (options.Format != "W" && Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
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

        MachineLearningWorkspaceNotebookAccessTokenResult IJsonModel<MachineLearningWorkspaceNotebookAccessTokenResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspaceNotebookAccessTokenResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(document.RootElement, options);
        }

        internal static MachineLearningWorkspaceNotebookAccessTokenResult DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string notebookResourceId = default;
            string hostName = default;
            string publicDns = default;
            string accessToken = default;
            string tokenType = default;
            int? expiresIn = default;
            string refreshToken = default;
            string scope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notebookResourceId"u8))
                {
                    notebookResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicDns"u8))
                {
                    publicDns = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenType"u8))
                {
                    tokenType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiresIn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresIn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("refreshToken"u8))
                {
                    refreshToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningWorkspaceNotebookAccessTokenResult(
                notebookResourceId,
                hostName,
                publicDns,
                accessToken,
                tokenType,
                expiresIn,
                refreshToken,
                scope,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotebookResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notebookResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NotebookResourceId))
                {
                    builder.Append("  notebookResourceId: ");
                    if (NotebookResourceId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NotebookResourceId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NotebookResourceId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hostName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HostName))
                {
                    builder.Append("  hostName: ");
                    if (HostName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HostName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HostName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublicDns), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  publicDns: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PublicDns))
                {
                    builder.Append("  publicDns: ");
                    if (PublicDns.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PublicDns}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PublicDns}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessToken), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accessToken: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccessToken))
                {
                    builder.Append("  accessToken: ");
                    if (AccessToken.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AccessToken}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AccessToken}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TokenType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tokenType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TokenType))
                {
                    builder.Append("  tokenType: ");
                    if (TokenType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TokenType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TokenType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpiresIn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expiresIn: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpiresIn))
                {
                    builder.Append("  expiresIn: ");
                    builder.AppendLine($"{ExpiresIn.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RefreshToken), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  refreshToken: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RefreshToken))
                {
                    builder.Append("  refreshToken: ");
                    if (RefreshToken.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RefreshToken}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RefreshToken}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Scope), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scope: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Scope))
                {
                    builder.Append("  scope: ");
                    if (Scope.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Scope}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Scope}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspaceNotebookAccessTokenResult)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningWorkspaceNotebookAccessTokenResult IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspaceNotebookAccessTokenResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
