using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Friend : IObserver
    {
        private string _name;

        public Friend(string name)
        {
            _name = name;
        }

        public void Update(User user)
        {
            if (user.Friends.Contains(_name))
            {
                Console.WriteLine($"Dear {_name}, your friend {user.Name} just posted a new update: {user.Posts[user.Posts.Count - 1]}.");
            }
        }
    }
}
