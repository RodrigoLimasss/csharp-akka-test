using System;
using Akka.Actor;
using csharp_akka_test.Actors;
using csharp_akka_test.Messages;

namespace csharp_akka_test
{
    class Program
    {
        private static ActorSystem _actorSystem;

        static void Main(string[] args)
        {
            _actorSystem = ActorSystem.Create("myActorSystem");

            IActorRef actorOne = _actorSystem.ActorOf(Props.Create<ActorOne>(), "ActorOne");
            actorOne.Tell(new MessageOne("Rodrigo Lima", 27));

            Console.ReadKey();

            _actorSystem.RegisterOnTermination(new Action(PrintTerminate));
            _actorSystem.Terminate();
            _actorSystem.WhenTerminated.Start();
            
            Console.ReadKey();
        }

        static void PrintTerminate()
        {
            Console.WriteLine("\nActorSystem terminated.");
            Console.WriteLine("\nPress some key to exit.");
        }
    }
}
