using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Model
{
    internal class Player
    {
        private int id;
        private string name;
        private int age;
        private const int MinimumAge = 18;

        
        public Player(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            Console.WriteLine("inside 3 params constructor");
        }
        public Player(int id,string name):this(id,name,MinimumAge)
        {
            Console.WriteLine("inside 2 params constructor");
        }
        public Player WhoIsElder(Player player2)
        {
            if(player2.age > this.age ) 
            {
                return this;
            }
            else
            {
                return player2;
            }
        }
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
    }
}
