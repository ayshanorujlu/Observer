using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class User : ISubject
    {
        public string? Name { get; set; }

        public List<string> Friends { get; set; } = new();

        public List<string> Posts { get; set; } = new();

        private List<IObserver> _observers = new();
        public void Attach(IObserver observer)
        {
            Console.WriteLine($"User {Name}: Attached an observer.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"User {Name}: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine($"User {Name}: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void AddPost(string post)
        {
            Posts.Add(post);
            Console.WriteLine($"User {Name}: Added new post - {post}.");
            Notify();
        }
    }
}
