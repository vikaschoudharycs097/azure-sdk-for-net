// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingAccountProperties : IUtf8JsonSerializable, IJsonModel<BillingAccountProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingAccountProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingAccountProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAccountProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingAccountProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AccountStatus))
            {
                writer.WritePropertyName("accountStatus"u8);
                writer.WriteStringValue(AccountStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AccountType))
            {
                writer.WritePropertyName("accountType"u8);
                writer.WriteStringValue(AccountType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AccountSubType))
            {
                writer.WritePropertyName("accountSubType"u8);
                writer.WriteStringValue(AccountSubType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AccountStatusReasonCode))
            {
                writer.WritePropertyName("accountStatusReasonCode"u8);
                writer.WriteStringValue(AccountStatusReasonCode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AgreementType))
            {
                writer.WritePropertyName("agreementType"u8);
                writer.WriteStringValue(AgreementType.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(EnrollmentDetails))
            {
                writer.WritePropertyName("enrollmentDetails"u8);
                writer.WriteObjectValue(EnrollmentDetails, options);
            }
            if (Optional.IsDefined(HasReadAccess))
            {
                writer.WritePropertyName("hasReadAccess"u8);
                writer.WriteBooleanValue(HasReadAccess.Value);
            }
            if (Optional.IsDefined(HasNoBillingProfiles))
            {
                writer.WritePropertyName("hasNoBillingProfiles"u8);
                writer.WriteBooleanValue(HasNoBillingProfiles.Value);
            }
            if (Optional.IsDefined(NotificationEmailAddress))
            {
                writer.WritePropertyName("notificationEmailAddress"u8);
                writer.WriteStringValue(NotificationEmailAddress);
            }
            if (Optional.IsDefined(PrimaryBillingTenantId))
            {
                writer.WritePropertyName("primaryBillingTenantId"u8);
                writer.WriteStringValue(PrimaryBillingTenantId.Value);
            }
            if (Optional.IsDefined(SoldTo))
            {
                writer.WritePropertyName("soldTo"u8);
                writer.WriteObjectValue(SoldTo, options);
            }
            if (Optional.IsDefined(RegistrationNumber))
            {
                writer.WritePropertyName("registrationNumber"u8);
                writer.WriteObjectValue(RegistrationNumber, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BillingRelationshipTypes))
            {
                writer.WritePropertyName("billingRelationshipTypes"u8);
                writer.WriteStartArray();
                foreach (var item in BillingRelationshipTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Qualifications))
            {
                writer.WritePropertyName("qualifications"u8);
                writer.WriteStartArray();
                foreach (var item in Qualifications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TaxIds))
            {
                writer.WritePropertyName("taxIds"u8);
                writer.WriteStartArray();
                foreach (var item in TaxIds)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        BillingAccountProperties IJsonModel<BillingAccountProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAccountProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingAccountProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingAccountProperties(document.RootElement, options);
        }

        internal static BillingAccountProperties DeserializeBillingAccountProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingProvisioningState? provisioningState = default;
            BillingAccountStatus? accountStatus = default;
            BillingAccountType? accountType = default;
            BillingAccountSubType? accountSubType = default;
            BillingAccountStatusReasonCode? accountStatusReasonCode = default;
            BillingAgreementType? agreementType = default;
            string displayName = default;
            BillingAccountEnrollmentDetails enrollmentDetails = default;
            bool? hasReadAccess = default;
            bool? hasNoBillingProfiles = default;
            string notificationEmailAddress = default;
            Guid? primaryBillingTenantId = default;
            BillingAddressDetails soldTo = default;
            BillingRegistrationNumber registrationNumber = default;
            IReadOnlyList<BillingRelationshipType> billingRelationshipTypes = default;
            IReadOnlyList<string> qualifications = default;
            IList<BillingTaxIdentifier> taxIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new BillingProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accountStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountStatus = new BillingAccountStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountType = new BillingAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accountSubType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountSubType = new BillingAccountSubType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accountStatusReasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountStatusReasonCode = new BillingAccountStatusReasonCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("agreementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agreementType = new BillingAgreementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enrollmentDetails = BillingAccountEnrollmentDetails.DeserializeBillingAccountEnrollmentDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("hasReadAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasReadAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hasNoBillingProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasNoBillingProfiles = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("notificationEmailAddress"u8))
                {
                    notificationEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryBillingTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryBillingTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("soldTo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    soldTo = BillingAddressDetails.DeserializeBillingAddressDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("registrationNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registrationNumber = BillingRegistrationNumber.DeserializeBillingRegistrationNumber(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingRelationshipTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingRelationshipType> array = new List<BillingRelationshipType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new BillingRelationshipType(item.GetString()));
                    }
                    billingRelationshipTypes = array;
                    continue;
                }
                if (property.NameEquals("qualifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    qualifications = array;
                    continue;
                }
                if (property.NameEquals("taxIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingTaxIdentifier> array = new List<BillingTaxIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingTaxIdentifier.DeserializeBillingTaxIdentifier(item, options));
                    }
                    taxIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingAccountProperties(
                provisioningState,
                accountStatus,
                accountType,
                accountSubType,
                accountStatusReasonCode,
                agreementType,
                displayName,
                enrollmentDetails,
                hasReadAccess,
                hasNoBillingProfiles,
                notificationEmailAddress,
                primaryBillingTenantId,
                soldTo,
                registrationNumber,
                billingRelationshipTypes ?? new ChangeTrackingList<BillingRelationshipType>(),
                qualifications ?? new ChangeTrackingList<string>(),
                taxIds ?? new ChangeTrackingList<BillingTaxIdentifier>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccountStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accountStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccountStatus))
                {
                    builder.Append("  accountStatus: ");
                    builder.AppendLine($"'{AccountStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccountType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accountType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccountType))
                {
                    builder.Append("  accountType: ");
                    builder.AppendLine($"'{AccountType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccountSubType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accountSubType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccountSubType))
                {
                    builder.Append("  accountSubType: ");
                    builder.AppendLine($"'{AccountSubType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccountStatusReasonCode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accountStatusReasonCode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccountStatusReasonCode))
                {
                    builder.Append("  accountStatusReasonCode: ");
                    builder.AppendLine($"'{AccountStatusReasonCode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AgreementType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  agreementType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AgreementType))
                {
                    builder.Append("  agreementType: ");
                    builder.AppendLine($"'{AgreementType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("  displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnrollmentDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enrollmentDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnrollmentDetails))
                {
                    builder.Append("  enrollmentDetails: ");
                    BicepSerializationHelpers.AppendChildObject(builder, EnrollmentDetails, options, 2, false, "  enrollmentDetails: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HasReadAccess), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hasReadAccess: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HasReadAccess))
                {
                    builder.Append("  hasReadAccess: ");
                    var boolValue = HasReadAccess.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HasNoBillingProfiles), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hasNoBillingProfiles: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HasNoBillingProfiles))
                {
                    builder.Append("  hasNoBillingProfiles: ");
                    var boolValue = HasNoBillingProfiles.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotificationEmailAddress), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notificationEmailAddress: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NotificationEmailAddress))
                {
                    builder.Append("  notificationEmailAddress: ");
                    if (NotificationEmailAddress.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NotificationEmailAddress}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NotificationEmailAddress}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryBillingTenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  primaryBillingTenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrimaryBillingTenantId))
                {
                    builder.Append("  primaryBillingTenantId: ");
                    builder.AppendLine($"'{PrimaryBillingTenantId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SoldTo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  soldTo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SoldTo))
                {
                    builder.Append("  soldTo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SoldTo, options, 2, false, "  soldTo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RegistrationNumber), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  registrationNumber: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RegistrationNumber))
                {
                    builder.Append("  registrationNumber: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RegistrationNumber, options, 2, false, "  registrationNumber: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingRelationshipTypes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingRelationshipTypes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BillingRelationshipTypes))
                {
                    if (BillingRelationshipTypes.Any())
                    {
                        builder.Append("  billingRelationshipTypes: ");
                        builder.AppendLine("[");
                        foreach (var item in BillingRelationshipTypes)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Qualifications), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  qualifications: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Qualifications))
                {
                    if (Qualifications.Any())
                    {
                        builder.Append("  qualifications: ");
                        builder.AppendLine("[");
                        foreach (var item in Qualifications)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TaxIds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  taxIds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(TaxIds))
                {
                    if (TaxIds.Any())
                    {
                        builder.Append("  taxIds: ");
                        builder.AppendLine("[");
                        foreach (var item in TaxIds)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  taxIds: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingAccountProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAccountProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerBillingContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingAccountProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BillingAccountProperties IPersistableModel<BillingAccountProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAccountProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBillingAccountProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingAccountProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingAccountProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
