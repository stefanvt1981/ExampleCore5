using System;

namespace ExampleCore5
{
    internal class NullableTest
    {
        internal static void Run()
        {
            string? hello = "hello world";
            hello = null;

            // Old approach
            if (!string.IsNullOrEmpty(hello))
            {
                Console.WriteLine($"{hello} has {hello.Length} letters.");
            }

            // New approach, with a property pattern
            if (hello is { Length: >0 })
            {
                Console.WriteLine($"{hello} has {hello.Length} letters.");
            }

            // For arrays
            string?[]? greetings = new string[2];
            greetings[0] = "Hello world";
            greetings = null;

            // Old approach
            if (greetings != null && !string.IsNullOrEmpty(greetings[0]))
            {
                Console.WriteLine($"{greetings[0]} has {greetings[0].Length} letters.");
            }

            // New approach
            if (greetings?[0] is {Length: > 0} hi)
            {
                Console.WriteLine($"{hi} has {hi.Length} letters.");
            }
        }
    }
}