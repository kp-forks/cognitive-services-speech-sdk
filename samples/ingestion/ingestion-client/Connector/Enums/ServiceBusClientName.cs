// <copyright file="ServiceBusClientName.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
// </copyright>

namespace Connector.Enums
{
    public enum ServiceBusClientName
    {
        None = 0,
        StartTranscriptionServiceBusClient,
        FetchTranscriptionServiceBusClient,
        CompletedTranscriptionServiceBusClient,
    }
}
