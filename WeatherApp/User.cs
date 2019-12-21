using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class User
    {
        static int currentId = 1;

        int id;
        string name;

        public User(string name)
        {
            id = currentId++;
            this.name = name;
        }

        public bool CheckName(string name)
        {
            if (this.name.ToLower().Contains(name.ToLower()))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"ID: {id}\tName: {name}\n";
        }
    }
}
