# Phobos.Actor.Common

![Phobos™ logo](/docs/images/phobos_logo.png)

`Phobos.Actor.Common` is a set of interfaces designed for use with Petabridge's [Phobos Enterprise Integration Suite for Akka.NET](https://phobos.petabridge.com/). 

At present, this repository exposes the following interfaces for use within [Akka.NET](http://getakka.net/) applications that intend to leverage Phobos in production:

* [`INeverTrace`](https://phobos.petabridge.com/api/Phobos.Actor.Common.INeverTrace.html) - permanently disables tracing support for any actors marked with this interface and cannot be overridden by configuration.
* [`INeverMonitor`](https://phobos.petabridge.com/api/Phobos.Actor.Common.INeverMonitor.html) - permanently disables monitoring support for any actors marked with this interface and cannot be overridden by configuration.

These components are used both by internal pieces of Phobos infrastructure (i.e. you don't want a monitoring system that recursively records monitoring events for itself) and can also be freely used by end-users seeking to leverage Phobos in production. 

But bear in mind: most end-user needs with respect to toggling tracing and monitoring on or off can be handled through [`Phobos.Actor`'s configuration capabilities](https://phobos.petabridge.com/articles/actor/index.html). 

## License
Phobos is a commercial product and [its end-user license agreement can be found here](https://phobos.petabridge.com/articles/setup/license.html).

`Phobos.Actor.Common`, however, is open source and is [licensed under the terms of Apache 2.0](LICENSE).