using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather(-5, 2, 111, 10, "s");
            Weather weather1 = new Weather(-12, 2, 111, 10, "r");
            Weather weather2 = new Weather(28, 32, 12, 10, "s");
            Weather weather3 = new Weather(-5, 2, 56, 10);


            Weather[] weatherArr = new Weather[5];
            weatherArr[0] = weather;
            weatherArr[1] = weather1;
            weatherArr[2] = weather2;
            weatherArr[3] = weather3;
            weatherArr[4] = new Weather();

            //foreach (Weather item in weatherArr)
            //{
            //    Console.WriteLine(item);
            //}

            UserDB userDB = new UserDB();

            User user = new User("John Connor");
            User user1 = new User("Sara Connor");

            userDB.Add(user);
            userDB.Add(user1);

            userDB.Add(new User[] { user, user1 });

            User userSearch = userDB.FindByName("Connor");

            if (userSearch == null)
            {
                Console.WriteLine("Not Found!");
            }
            else
            {
                Console.WriteLine(userSearch);
            }

            //Console.WriteLine(userDB);
        }
    }
}
