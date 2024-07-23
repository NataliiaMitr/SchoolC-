using System;

namespace ClassUser
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User(int userID, string name, int age)
        {
            UserID = userID;
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"UserID: {UserID}, Name: {Name}, Age: {Age}");
        }

        public static void ChangeUserAge(User user, int newAge)
        {
            user.Age = newAge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "Test User", 25);

            user.PrintInfo();

            User.ChangeUserAge(user, 30);

            user.PrintInfo();
        }
    }
}
