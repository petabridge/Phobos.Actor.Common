# Phobos.Actor.Common

![Phobos™ logo](/docs/images/phobos_logo.png)

`Phobos.Actor.Common` is a set of interfaces designed for use with Petabridge's [Phobos Enterprise Integration Suite for Akka.NET](https://phobos.petabridge.com/). 

At present, this repository exposes the following interfaces for use within [Akka.NET](http://getakka.net/) applications that intend to leverage Phobos in production:

* [`INeverTrace`](https://phobos.petabridge.com/api/Phobos.Actor.Common.INeverTrace.html) - permanently disables tracing support for any actors marked with this interface and cannot be overridden by configuration.
* [`ITrace`](https://phobos.petabridge.com/api/Phobos.Actor.Common.ITrace.html) - explicitly adds tracing support to a message, actor, etc.
* [`INeverMonitor`](https://phobos.petabridge.com/api/Phobos.Actor.Common.INeverMonitor.html) - permanently disables monitoring support for any actors marked with this interface and cannot be overridden by configuration.
* [`IMonitor`](https://phobos.petabridge.com/api/Phobos.Actor.Common.IMonitor.html) - explicitly adds monitoring support to a message, actor, etc.

And then we have some aggregate interfaces for simplification purposes:

* [`INeverInstrumented`](https://phobos.petabridge.com/api/Phobos.Actor.Common.INeverInstrumented.html) - permanently disables tracing and monitoring support for any actors marked with this interface and cannot be overridden by configuration.
* [`IInstrumented`](https://phobos.petabridge.com/api/Phobos.Actor.Common.IInstrumented.html) - explicitly enables both tracing and monitoring support for this object.

These components are used both by internal pieces of Phobos infrastructure (i.e. you don't want a monitoring system that recursively records monitoring events for itself) and can also be freely used by end-users seeking to leverage Phobos in production. 

## License
Phobos is a commercial product and [its end-user license agreement can be found here](https://phobos.petabridge.com/articles/setup/license.html).

`Phobos.Actor.Common`, however, is open source and is [licensed under the terms of Apache 2.0](LICENSE).