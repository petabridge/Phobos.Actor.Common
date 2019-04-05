// -----------------------------------------------------------------------
// <copyright file="INeverTrace.cs" company="Petabridge, LLC">
//      Copyright (C) 2018 - 2018 Petabridge, LLC <https://petabridge.com>
// </copyright>
// -----------------------------------------------------------------------

namespace Phobos.Actor.Common
{
    /// <summary>
    ///     Marker interface used to indicate that this actor or message
    ///     never produces Phobos.Tracing events under any circumstances.
    /// </summary>
    /// <remarks>
    ///     This interface cannot be overridden by configuration.
    /// </remarks>
    public interface INeverTrace
    {
    }
}