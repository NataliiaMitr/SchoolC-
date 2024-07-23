using System;

public class Messenger
{
    public static string State;

    private string message;
    private int messageCounter;

    static Messenger()
    {
        State = "Initialized";
    }

    public Messenger(string message, int messageCounter)
    {
        this.message = message;
        this.messageCounter = messageCounter;
    }

    public void Deconstruct(out string message, out int messageCounter)
    {
        message = this.message;
        messageCounter = this.messageCounter;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Message: {message}, Counter: {messageCounter}, State: {State}");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"Initial State: {Messenger.State}");

        Messenger messenger = new Messenger("Test text", 1);

        messenger.PrintInfo();

        messenger.Deconstruct(out string msg, out int counter);
        Console.WriteLine($"Deconstructed Message: {msg}, Counter: {counter}");
    }
}
