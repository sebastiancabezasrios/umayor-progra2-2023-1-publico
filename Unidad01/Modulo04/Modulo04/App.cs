using System;
namespace Modulo04
{
	public class App
	{
		public static void Main()
		{
            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape", "strawberry" };
            IEnumerable<string> query = fruits.Where(fruit => fruit.Length > 6);
            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }

            int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 75 };
            IEnumerable<int> query2 = numbers.Where((number, index) => number <= index * 10);
            foreach (int number in query2)
            {
                Console.WriteLine(number);
            }
        }
    }
}

