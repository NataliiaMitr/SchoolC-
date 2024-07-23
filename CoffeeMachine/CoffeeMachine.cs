using System;

namespace CoffeeMachineApp
{
    public class CoffeeMachine
    {
    }
    public class CoffeeMachinePhilips : CoffeeMachine
    {
    }
    public abstract class CoffeeOptions
    {
        public abstract void MakeLatte();
    }
    public class Coffee : CoffeeOptions
    {
        public override void MakeLatte()
        {
        }
    }

    public class Barista
    {
        private void MakingSecretCoffee()
        {
        }

        public virtual void MakingEspresso()
        {
        }
    }

    public class Trainee : Barista
    {
        public override void MakingEspresso()
        {

        }
    }
    
}
