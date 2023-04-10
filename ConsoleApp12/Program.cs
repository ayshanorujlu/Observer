using ConsoleApp12;

var user1 = new User
{

    Name = "John",
    Friends = new() { "Jane", "Tom" }
};

var friend1 = new Friend("Jane");

user1.Attach(friend1);

var friend2 = new Friend("Tom");
user1.Attach(friend2);

user1.AddPost("Hello, world!");

user1.Detach(friend2);

user1.AddPost("This is my second post.");

Console.ReadLine();
