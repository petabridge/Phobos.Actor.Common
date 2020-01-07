// -----------------------------------------------------------------------
// <copyright file="IInstrumented.cs" company="Petabridge, LLC">
//      Copyright (C) 2015 - 2020 Petabridge, LLC <https://petabridge.com>
// </copyright>
// -----------------------------------------------------------------------

namespace Phobos.Actor.Common
{
    /// <summary>
    ///     Marker interface that indicates that this resource is fully instrumented.
    /// </summary>
    public interface IInstrumented : IWithTrace, IWithMetrics
    {
    }
}