// -----------------------------------------------------------------------
// <copyright file="NodeLabel.cs" company="Petabridge, LLC">
//      Copyright (C) 2015 - 2020 Petabridge, LLC <https://petabridge.com>
// </copyright>
// -----------------------------------------------------------------------

namespace Phobos.Actor.Common
{
    /// <summary>
    /// The label used to identify the node and service type inside monitoring and tracing systems.
    /// </summary>
    public sealed class NodeLabel
    {
        public NodeLabel(string serviceName, string address)
        {
            ServiceName = serviceName;
            Address = address;
        }

        /// <summary>
        /// human-friendly name for the service, i.e. "backend," "frontend," "ingestion-api," etc...
        /// </summary>
        public string ServiceName { get; }

        /// <summary>
        /// The address of this instance of the service,
        ///
        /// i.e. https://foo1.bar.com/
        /// </summary>
        public string Address { get; }
    }
}