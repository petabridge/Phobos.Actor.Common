# Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
_3/8/2018 8:37:49 PM_
### System Info
```ini
NBench=NBench, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
OS=Microsoft Windows NT 6.2.9200.0
ProcessorCount=16
CLR=4.0.30319.42000,IsMono=False,MaxGcGeneration=2
```

### NBench Settings
```ini
RunMode=Throughput, TestMode=Measurement
NumberOfIterations=5, MaximumRunTime=00:00:01
Concurrent=True
Tracing=True
```

## Data
-------------------

### Totals
|          Metric |           Units |             Max |         Average |             Min |          StdDev |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalCollections [Gen0] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|TotalCollections [Gen1] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|TotalBytesAllocated |           bytes |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] Operations |      operations |   25,548,331.00 |   25,548,331.00 |   25,548,331.00 |            0.00 |

### Per-second Totals
|          Metric |       Units / s |         Max / s |     Average / s |         Min / s |      StdDev / s |
|---------------- |---------------- |---------------- |---------------- |---------------- |---------------- |
|TotalCollections [Gen0] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|TotalCollections [Gen1] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|TotalCollections [Gen2] |     collections |            0.00 |            0.00 |            0.00 |            0.00 |
|TotalBytesAllocated |           bytes |            0.00 |            0.00 |            0.00 |            0.00 |
|[Counter] Operations |      operations |  160,499,719.60 |  160,410,169.13 |  160,331,602.34 |       60,754.21 |

### Raw Data
#### TotalCollections [Gen0]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  159,278,895.76 |
|               2 |            0.00 |            0.00 |  159,284,357.02 |
|               3 |            0.00 |            0.00 |  159,346,820.13 |
|               4 |            0.00 |            0.00 |  159,253,978.78 |
|               5 |            0.00 |            0.00 |  159,179,910.50 |

#### TotalCollections [Gen1]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  159,278,895.76 |
|               2 |            0.00 |            0.00 |  159,284,357.02 |
|               3 |            0.00 |            0.00 |  159,346,820.13 |
|               4 |            0.00 |            0.00 |  159,253,978.78 |
|               5 |            0.00 |            0.00 |  159,179,910.50 |

#### TotalCollections [Gen2]
|           Run # |     collections | collections / s |ns / collections |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  159,278,895.76 |
|               2 |            0.00 |            0.00 |  159,284,357.02 |
|               3 |            0.00 |            0.00 |  159,346,820.13 |
|               4 |            0.00 |            0.00 |  159,253,978.78 |
|               5 |            0.00 |            0.00 |  159,179,910.50 |

#### TotalBytesAllocated
|           Run # |           bytes |       bytes / s |      ns / bytes |
|---------------- |---------------- |---------------- |---------------- |
|               1 |            0.00 |            0.00 |  159,278,895.76 |
|               2 |            0.00 |            0.00 |  159,284,357.02 |
|               3 |            0.00 |            0.00 |  159,346,820.13 |
|               4 |            0.00 |            0.00 |  159,253,978.78 |
|               5 |            0.00 |            0.00 |  159,179,910.50 |

#### [Counter] Operations
|           Run # |      operations |  operations / s | ns / operations |
|---------------- |---------------- |---------------- |---------------- |
|               1 |   25,548,331.00 |  160,399,975.64 |            6.23 |
|               2 |   25,548,331.00 |  160,394,476.13 |            6.23 |
|               3 |   25,548,331.00 |  160,331,602.34 |            6.24 |
|               4 |   25,548,331.00 |  160,425,071.92 |            6.23 |
|               5 |   25,548,331.00 |  160,499,719.60 |            6.23 |


## Traces
[NBench][DEBUG][3/8/2018 8:37:33 PM][Thread 0001] Beginning Warmups for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][DEBUG][3/8/2018 8:37:33 PM][Thread 0001] ----- BEGIN PRE-WARMUP -----
[NBench][INFO][3/8/2018 8:37:33 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][DEBUG][3/8/2018 8:37:33 PM][Thread 0001] Throughput mode: estimating how many invocations of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1 will take 1s
[NBench][DEBUG][3/8/2018 8:37:47 PM][Thread 0001] Throughput mode: executed 87203803 instances of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1 in roughly 1s. Using that figure for benchmark.
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Generating report for warmup 1 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][DEBUG][3/8/2018 8:37:47 PM][Thread 0001] ----- END PRE-WARMUP -----
[NBench][DEBUG][3/8/2018 8:37:47 PM][Thread 0001] ----- BEGIN WARMUPS -----
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Generating report for warmup 1 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Generating report for warmup 1 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Generating report for warmup 1 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:47 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Generating report for warmup 1 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Generating report for warmup 1 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][DEBUG][3/8/2018 8:37:48 PM][Thread 0001] ----- END WARMUPS -----
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Generating report for run 1 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Generating report for run 2 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Generating report for run 3 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Generating report for run 4 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking setup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:48 PM][Thread 0001] Invoking Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:49 PM][Thread 0001] Invoking cleanup for Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1
[NBench][INFO][3/8/2018 8:37:49 PM][Thread 0001] Generating report for run 5 of Phobos.Actor.Common.Tests.Performance.UnitTest1+TestMethod1


