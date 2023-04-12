using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ApplicationConfigApp.Model
{
    internal class Configurationfile
    {
        private string _server;
        private string _database;
        public Configurationfile(string line)
        {
            string[] words = line.Split(';');
            //Console.WriteLine(name);
            string server = "";
            string database = "";
            foreach (string word in words)
            {
                Console.WriteLine(word);
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
            _server = server;
            _database = database;
            /*Console.WriteLine($"server : {server}");
            Console.WriteLine($"database : {database}");*/
        }
        public string Server
        {
            get { return _server; }
        }
        public string Database
        {
            get { return _database; }
        }
        
    }
}
