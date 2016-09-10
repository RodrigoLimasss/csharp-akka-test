namespace csharp_akka_test.Messages
{
    public class MessageOne
    {
        public string Name { get; private set; }
        public int Id { get; private set; }

        public MessageOne(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
