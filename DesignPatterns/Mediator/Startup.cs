namespace DesignPatterns.Mediator
{
    class Startup
    {
        static void Main(string[] args)
        {
            var chatRoom = new ChatRoom();

            var john = new Person("John");
            var jane = new Person("Jane");

            chatRoom.Join(john);
            chatRoom.Join(jane);

            john.Say("hi room");
            jane.Say("oh, hey john");

            var simon = new Person("Simon");
            chatRoom.Join(simon);
            simon.Say("hi everyone!");

            jane.PrivateMessage("Simon", "glad you could join us!");
        }
    }
}
