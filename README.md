# csharp-akka-test
This repository is only for test Akka.Net.


# Akka

Construir sistemas scaláveis, concorrentes, com alta taxa de transferência e baixa latência.

No manual thread management, Higher abstraction level, scale up, scale out, Fault tolerance and handling, Common single architecture.

Reactive Manifest = Resilient - Message Driven - Elastic - Responsive.

50 milhões de messages per second per machine
1GB memory = ~2.5 million Actors

Each actor have an address
Actor instances are lazy

~300 bytes overhead per instance

Location Transparency: The ability to send message to another actor without needing to know where it it.

Supervision allow the system deal with faults and became self-healing.

Thread-safe: Immutable messages.

Actor Lifecycle Hook
- PreStart: Called before actor instance receives first message;
- PostStop: Called after all actors e childrens has been stopped;
- PreRestart: Called before actor begins restarting. Save current message for reprocessing later when actor restarts;
- PostRestart: Called after PreRestart() and before PreStart(). Allows code to do something with exception.

[![](https://lh5.googleusercontent.com/nFPmEP5qdE1-MZ1iMyeMmPDJUK793wtAusLthRl9mQydDN3XQCqZqoQmFyjoFn-MUR94vyzzgPwop_sF2S8jtA=w1366-h638-rw)](https://lh5.googleusercontent.com/nFPmEP5qdE1-MZ1iMyeMmPDJUK793wtAusLthRl9mQydDN3XQCqZqoQmFyjoFn-MUR94vyzzgPwop_sF2S8jtA=w1366-h638-rw)

Shutdown
- Termination happens asynchronously.
- PoisonPill: If actor have n messages in mailbox, it's process before shutdown.
- GracefulStop: To manually terminate and wait (TimeSpan).


Behaviours
- Become: Switching to new explicitly specified behaviour, existents not remembered.
- BecomeStacked: Switching to new behaviour and pushes existing behaviour down to stack.
- UnbecomeStacked: pops current behaviour off stack and the preciously pushed behaviour is restored.



