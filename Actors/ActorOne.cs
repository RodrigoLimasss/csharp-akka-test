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

        protected override void PreStart()
        {
            //base.PreStart();
            Console.WriteLine("PreStart: before actor receive first message.");
        }

        protected override void PostStop()
        {
            //base.PostStop();
            Console.WriteLine("PostStop: after the actor has been stopped.");
        }

        protected override void PreRestart(Exception reason, object message)
        {
            Console.WriteLine("PreRestart: before actor begins restarting.");
            Console.WriteLine("PreRestart reason: " + reason);
            base.PreRestart(reason, message);
        }

        protected override void PostRestart(Exception reason)
        {
            Console.WriteLine("PostRestart: after PreRestart() and before PreStart();");
            Console.WriteLine("PostRestart reason: " + reason);
            base.PostRestart(reason);
        }
    }
}
