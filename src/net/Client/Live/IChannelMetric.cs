﻿// Copyright 2012 Microsoft Corporation
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.ObjectModel;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    /// <summary>
    /// Describes the channel Metrics Entity
    /// </summary>
    public interface IChannelMetric
    {
        /// <summary>
        /// Gets Unique identifier of the channel Metric.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Gets service name of the channel metric
        /// </summary>
        string ServiceName { get; }

        /// <summary>
        /// Gets metric last modification timestamp.
        /// </summary>
        DateTime LastModified { get; }

        /// <summary>
        /// Gets the <see cref="IngestMetrics"/> object containing the ingest metrics of the channel.
        /// </summary>
        ReadOnlyCollection<IIngestMetric> IngestMetrics { get; }

        /// <summary>
        /// Gets the <see cref="ProgramMetrics"/> object containing the program metrics of the channel.
        /// </summary>
        ReadOnlyCollection<IProgramMetric> ProgramMetrics { get; }
    }
}
