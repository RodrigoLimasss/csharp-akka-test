using System;
using Akka.Actor;
using csharp_akka_test.Messages;

namespace csharp_akka_test.Actors
{
    public class ActorOne : ReceiveActor
    {
        public ActorOne()
        {
            Console.WriteLine(Self.Path.Name);

            Receive<MessageOne>(message => OnReceive(message));
        }

        protected void OnReceive(MessageOne message)
        {
           Console.WriteLine(string.Format("{0}, {1}", message.Name, message.Id));
        }
    }
}
