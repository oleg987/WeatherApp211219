using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class UserDB
    {
        User[] users;

        public UserDB()
        {
            users = new User[0];
        }

        public UserDB(User user)
        {
            Add(user);
        }

        public void Add(User user)
        {
            if (users == null)
            {
                users = new User[0];
            }
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
        }

        public void Add(User[] usersArr)
        {
            //foreach (User item in usersArr)
            //{
            //    Add(item);
            //}
            int size = users.Length;
            Array.Resize(ref users, users.Length + usersArr.Length);
            for (int i = 0; i < usersArr.Length; i++)
            {
                users[users.Length - usersArr.Length + i] = usersArr[i];
                users[size + i] = usersArr[i];
            }
        }

        public User[] FindByName(string name)
        {
            User[] finded = new User[0];

            foreach (User item in users)
            {
                if (item.CheckName(name))
                {
                     //item;
                }
            }

            return finded;
        }

        public override string ToString()
        {
            string result = "UserDB: \n";

            foreach (User item in users)
            {
                result += item.ToString();
            }

            return result;
        }
    }
}
