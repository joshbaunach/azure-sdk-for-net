// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsRouterJobClassificationFailedEventDataConverter))]
    public partial class AcsRouterJobClassificationFailedEventData
    {
        internal static AcsRouterJobClassificationFailedEventData DeserializeAcsRouterJobClassificationFailedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string classificationPolicyId = default;
            IReadOnlyList<AcsRouterCommunicationError> errors = default;
            string queueId = default;
            IReadOnlyDictionary<string, string> labels = default;
            IReadOnlyDictionary<string, string> tags = default;
            string jobId = default;
            string channelReference = default;
            string channelId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classificationPolicyId"u8))
                {
                    classificationPolicyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsRouterCommunicationError> array = new List<AcsRouterCommunicationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsRouterCommunicationError.DeserializeAcsRouterCommunicationError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsRouterJobClassificationFailedEventData(
                jobId,
                channelReference,
                channelId,
                queueId,
                labels ?? new ChangeTrackingDictionary<string, string>(),
                tags ?? new ChangeTrackingDictionary<string, string>(),
                classificationPolicyId,
                errors ?? new ChangeTrackingList<AcsRouterCommunicationError>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AcsRouterJobClassificationFailedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsRouterJobClassificationFailedEventData(document.RootElement);
        }

        internal partial class AcsRouterJobClassificationFailedEventDataConverter : JsonConverter<AcsRouterJobClassificationFailedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterJobClassificationFailedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AcsRouterJobClassificationFailedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterJobClassificationFailedEventData(document.RootElement);
            }
        }
    }
}
