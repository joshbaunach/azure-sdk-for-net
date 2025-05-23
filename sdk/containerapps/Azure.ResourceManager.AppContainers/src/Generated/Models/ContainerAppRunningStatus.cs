// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Running status of the Container App. </summary>
    public readonly partial struct ContainerAppRunningStatus : IEquatable<ContainerAppRunningStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppRunningStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppRunningStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ProgressingValue = "Progressing";
        private const string RunningValue = "Running";
        private const string StoppedValue = "Stopped";
        private const string SuspendedValue = "Suspended";
        private const string ReadyValue = "Ready";

        /// <summary> Container App is transitioning between Stopped and Running states. </summary>
        public static ContainerAppRunningStatus Progressing { get; } = new ContainerAppRunningStatus(ProgressingValue);
        /// <summary> Container App is in Running state. </summary>
        public static ContainerAppRunningStatus Running { get; } = new ContainerAppRunningStatus(RunningValue);
        /// <summary> Container App is in Stopped state. </summary>
        public static ContainerAppRunningStatus Stopped { get; } = new ContainerAppRunningStatus(StoppedValue);
        /// <summary> Container App Job is in Suspended state. </summary>
        public static ContainerAppRunningStatus Suspended { get; } = new ContainerAppRunningStatus(SuspendedValue);
        /// <summary> Container App Job is in Ready state. </summary>
        public static ContainerAppRunningStatus Ready { get; } = new ContainerAppRunningStatus(ReadyValue);
        /// <summary> Determines if two <see cref="ContainerAppRunningStatus"/> values are the same. </summary>
        public static bool operator ==(ContainerAppRunningStatus left, ContainerAppRunningStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppRunningStatus"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppRunningStatus left, ContainerAppRunningStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerAppRunningStatus"/>. </summary>
        public static implicit operator ContainerAppRunningStatus(string value) => new ContainerAppRunningStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppRunningStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppRunningStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
