using System;

namespace _4._10.Provider
{
    public class User
    {
        public int UserID { get; set; }
        public decimal Balance { get; set; }

        public User(int userID, decimal balance)
        {
            UserID = userID;
            Balance = balance;
        }
    }
    public class Provider<T> where T : User
    {
        public void CheckBalance(T user)
        {
            Console.WriteLine($"User ID: {user.UserID}, Balance: {user.Balance}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User(1, 1500);

            Provider<User> provider = new Provider<User>();

            provider.CheckBalance(user);
        }
    }
}

