// -----------------------------------------------------------------------
// <copyright file="INeverInstrumented.cs" company="Petabridge, LLC">
//      Copyright (C) 2015 - 2020 Petabridge, LLC <https://petabridge.com>
// </copyright>
// -----------------------------------------------------------------------

namespace Phobos.Actor.Common
{
    /// <summary>
    ///     Marker interface used to indicate that this particular resource is never instrumented.
    /// </summary>
    public interface INeverInstrumented : INeverTrace, INeverMonitor
    {
    }
}
