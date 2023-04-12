using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Linq;
using ApplicationConfigApp.Model;

namespace ApplicationConfigApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = ConfigurationManager.AppSettings["connection1"];
            Configurationfile configurationA =new Configurationfile(name1);
            PrintCofiguration(configurationA);
            string name2 = ConfigurationManager.AppSettings["connection2"];
            Configurationfile configurationB = new Configurationfile(name2);
            PrintCofiguration(configurationB);
            /*string[] words= name1.Split(';');
            //Console.WriteLine(name);
            string server = "";
            string database = "";
            foreach(string word in words)
            {
                //Console.WriteLine(word);
                string[] items = word.Split('=');
                if (items[0]== "server")
                {
                    server = items[1];
                }
                else if (items[0]== "database")
                {
                    database = items[1];
                }

            }
            Console.WriteLine($"server : {server}");
            Console.WriteLine($"database : {database}");*/
        }
        static void PrintCofiguration(Configurationfile configuration)
        {
            Console.WriteLine("server : " + configuration.Server);
            Console.WriteLine("database: " + configuration.Database);
            Console.WriteLine();
        }
        /*static void PrintName(string name)
        {
            string[] words = name.Split(';');
            //Console.WriteLine(name);
            string server = "";
            string database = "";
            foreach (string word in words)
            {
                //Console.WriteLine(word);
                string[] items = word.Split('=');
                if (items[0] == "server")
                {
                    server = items[1];
                }
                else if (items[0] == "database")
                {
                    database = items[1];
                }

            }
            Console.WriteLine($"server : {server}");
            Console.WriteLine($"database : {database}");
        }*/
    }
}
