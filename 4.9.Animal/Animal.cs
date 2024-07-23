using System;

namespace _4._9.Animal
{
    public abstract class Animal
    {
        public abstract void Sound();
    }

    public interface IRunable
    {
        void Run();
    }

    public interface IEatable
    {
        void Eat();
    }

    public interface ISleepable
    {
        void Sleep();
    }

    public interface IAnimal : IRunable, IEatable, ISleepable
    {
        void Sound();
    }

    public class Dog:Animal, IAnimal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }

        public void Run()
        {
            Console.WriteLine("Dog runs");
        }

        public void Eat()
        {
            Console.WriteLine("Dog eats");
        }

        public void Sleep()
        {
            Console.WriteLine("Dog sleeps");
        }
    }
    public class Cat : Animal, IAnimal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat meows");
        }

        void IRunable.Run()
        {
            Console.WriteLine("Cat runs");
        }

        void IEatable.Eat()
        {
            Console.WriteLine("Cat eats");
        }

        void ISleepable.Sleep()
        {
            Console.WriteLine("Cat sleeps");
        }
    public class Program
        {
        public static void Main(string[] args)
            {
                Dog dog = new Dog();
                dog.Sound();
                dog.Run();
                dog.Eat();
                dog.Sleep();

                Cat cat = new Cat();
                cat.Sound();
                ((IRunable)cat).Run();
                ((IEatable)cat).Eat();
                ((ISleepable)cat).Sleep();
            }
        }

    }
}

