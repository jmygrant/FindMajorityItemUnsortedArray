using System;
using System.Collections.Generic;
using System.Linq;

namespace FindMajorityItem
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] array = new int[] { 1, 2, 3, 4, 5, 2, 2, 2, 2, 2 };
			var result = FindMajorityItemFromUnsortedArray(array);
			Console.WriteLine(string.Format("The majority item is: {0}", result));

			Console.ReadLine();
        }

		public static int FindMajorityItemFromUnsortedArray(int[] array)
		{
			int majorityItem = array.Length / 2;
			Dictionary<int, int> dict = new Dictionary<int, int>();

			foreach(var item in array)
			{
				if(dict.ContainsKey(item))
				{
					dict[item]++;
					if(dict[item] > majorityItem)
					{
						return item;
					}
				}
				else
				{
					dict.Add(item, 1);
				}
			}
			//Majority Item not found return zero.
			return 0;
		}
    }
}
