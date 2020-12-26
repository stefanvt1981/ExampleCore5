using System;
using System.Diagnostics.CodeAnalysis;

namespace ExampleCore5
{    
    internal class NotNullWhenTest
    {
        internal static void Run()
        {
            bool? testNull;

            TestForNull(out testNull, true);
            
            Console.WriteLine($"TestForNull returnsNull=true: {testNull}");

            TestForNull(out testNull, false);

            Console.WriteLine($"TestForNull returnsNull=false: {testNull}");
        }

        private static bool TestForNull([NotNullWhen(true)] out bool? isNull, bool returnNull)
        {
            if(returnNull)
            {
                isNull = null;
            }
            else
            {
                isNull = false;
            }

            return true;
        }
    }
}