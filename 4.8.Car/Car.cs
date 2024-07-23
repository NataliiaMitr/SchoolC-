using System;

namespace _4._8.Car
{
    public class Car
    { 
        protected int quantity;
        protected int warranty;

        public Car(int quantity, int warranty)
        {
            this.quantity = quantity;
            this.warranty = warranty;
        }

        public virtual void GetQuantity()
        {
            Console.WriteLine($"Number of cars ready for use: {quantity}");
        }

        public virtual void GetFullInfo()
        {
            Console.WriteLine($"Quantity: {quantity}, Warranty: {warranty} years");
        }

        public void SetWarranty(int newWarranty)
        {
            warranty = newWarranty;
        }
        public class WV : Car
        {
            public WV(int quantity, int warranty) : base(quantity, warranty) { }

            public override void GetQuantity()
            {
                Console.WriteLine($"WV cars ready for use: {quantity}");
            }

            public override void GetFullInfo()
            {
                Console.WriteLine($"WV - Quantity: {quantity}, Warranty: {warranty} years");
            }

        }

        public class Toyota : Car
        {
            public Toyota(int quantity, int warranty) : base(quantity, warranty) { }

            public override void GetQuantity()
            {
                Console.WriteLine($"Toyota cars ready for use: {quantity}");
            }

            public sealed override void GetFullInfo()
            {
                Console.WriteLine($"Toyota - Quantity: {quantity}, Warranty: {warranty} years");
            }

        }
        public class Audi : WV
            {
                public Audi(int quantity, int warranty) : base(quantity, warranty) { }

                public override void GetQuantity()
                {
                    Console.WriteLine($"Audi cars ready for use: {quantity}");
                }

                public void GetFullInfo(int newWarranty)
                {
                    Console.WriteLine($"Audi - Quantity: {quantity}, Warranty: {newWarranty} years");
                }

        public class Program
                { 
                    public static void Main(string[] args)
                    {
                        Car car = new Car(300, 5);
                        car.GetQuantity();
                        car.GetFullInfo();

                        WV wv = new WV(100, 5);
                        wv.GetQuantity();
                        wv.GetFullInfo();

                        Toyota toyota = new Toyota(150, 5);
                        toyota.GetQuantity();
                        toyota.GetFullInfo();

                        Audi audi = new Audi(120, 3);
                        audi.GetQuantity();
                        audi.GetFullInfo();

                      
                       
                    }
                }
            }
        }
    }



