using System;

namespace Name
{
    public class NameEmailDate
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name:");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter your email:");
            string email = (Console.ReadLine());
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your password:");
            const int passwordLength = 4;
            char[] password = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                password[i] = '*';
            }

            for (int i = 0; i < passwordLength; i++)
            {
                Console.Write(password[i]);
            }
            //добавить и++ в условие
            for (int i = 0; i < passwordLength; i++)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (char.IsDigit(keyInfo.KeyChar))
                {
                    password[i] = keyInfo.KeyChar;

                    Console.SetCursorPosition(i, Console.CursorTop);
                    Console.Write(keyInfo.KeyChar);
                }
                else
                {
                    i--;
                }
            }

            string passwordStr = new string(password);
            Console.Clear();
            Console.WriteLine("User Information");
            Console.WriteLine(new string('-', 30));


            string newLine = $"\tName:{name}\n\tEmail:{email}\n\tAge:{age}\n\tPassword:{passwordStr}";
            Console.WriteLine(newLine);

            Console.WriteLine(new string('-', 30));

            int nameLenght = name.Length;
            Console.WriteLine($"The name lenght is: {nameLenght}");
        }
    }

}
