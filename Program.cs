// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Test(args);
        }

        static string testString = "Super String";

        static void Test(string[] args)
        {
            // const int testInt = 21;
            // System.Console.WriteLine(testString);
            // string test = "Hello World";
            // System.Console.WriteLine(new string(test.ToArray().Reverse().ToArray()));
            // System.Console.WriteLine(test.Length);
            // test += "12";
            // System.Console.WriteLine(test[3]);
            // string[] strArr = {"test", "try"};
            // int[] testArr = {2, 4, 2};
            // System.Console.WriteLine(String.Concat(Enumerable.Repeat(test, 3)));
            // System.Console.WriteLine(testArr.Average());
            // System.Console.WriteLine(testArr.Sum());
            // System.Console.WriteLine("********");
            // System.Console.WriteLine(String.Join(", ", Enumerable.Range(3, 5)));

            int a = 24, b = 18;
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a & b = {a & b}"); // 2-bit column only
            Console.WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
            Console.WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns
            Console.WriteLine($"b << 3 = {b << 3}"); // 8 and 4-bit columns
            Console.WriteLine($"b >> 3 = {b >> 3}"); // 8 and 4-bit columns

        }
    }
}