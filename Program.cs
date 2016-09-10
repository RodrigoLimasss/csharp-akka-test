using System;
using Akka.Actor;

namespace csharp_akka_test
{
    class Program
    {
        private static ActorSystem _actorSystem;

        static void Main(string[] args)
        {
            _actorSystem = ActorSystem.Create("myActorSystem");

            Console.WriteLine("Hello Akka: {0}", _actorSystem.Name);

            Console.ReadLine();
        }
    }
}
