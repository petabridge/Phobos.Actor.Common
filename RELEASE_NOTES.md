#### 1.1.0 January 06 2020 ####
Introduced the following interfaces:

* [`IWithTrace`](https://phobos.petabridge.com/api/Phobos.Actor.Common.IWithTrace.html) - explicitly adds tracing support to a message, actor, etc.
* [`IWithMonitor`](https://phobos.petabridge.com/api/Phobos.Actor.Common.IWithMonitor.html) - explicitly adds monitoring support to a message, actor, etc.
* [`INeverInstrumented`](https://phobos.petabridge.com/api/Phobos.Actor.Common.INeverInstrumented.html) - permanently disables tracing and monitoring support for any actors marked with this interface and cannot be overridden by configuration.
* [`IInstrumented`](https://phobos.petabridge.com/api/Phobos.Actor.Common.IInstrumented.html) - explicitly enables both tracing and monitoring support for this object.