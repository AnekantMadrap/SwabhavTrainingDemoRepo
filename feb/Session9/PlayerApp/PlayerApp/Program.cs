using PlayerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            Player playerA = new Player(1, "sachin", 50);
            Player playerB = new Player(2, "Virat",45);
            Player[] manyplayer = new Player[5];
            manyplayer[0] = playerA;
            manyplayer[1] = playerA;
            manyplayer[2] = new Player(3, "mahnedra", 40);
            manyplayer[3] = playerB;
            manyplayer[4] = playerB;
            foreach(Player player in manyplayer)
            {
                PrintDetails(player,"");
            }
        }

        private static void CaseStudy1()
        {
            Player playerA = new Player(1, "sachin", 50);
            //PrintDetails(playerA, "Details of Player A");
            Player playerB = new Player(2, "Virat");
            //PrintDetails(playerB, "Details of Player B");
            Player elder = playerA.WhoIsElder(playerB);
            //PrintDetails(elder, "Details of elder");
            Console.WriteLine(elder.Name);
            Console.WriteLine(playerA.GetHashCode());
            Console.WriteLine(playerB.GetHashCode());
            Console.WriteLine(elder.GetHashCode());
        }

        static void PrintDetails(Player player,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Id:"+player.Id);
            Console.WriteLine("name:"+player.Name);
            Console.WriteLine("age:"+player.Age);
            //Console.WriteLine("whho is elder"+player.WhoIsElder(player);

        }
    }
}
