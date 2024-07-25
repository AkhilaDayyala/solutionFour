using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace project4
{
    internal class DuplicateCount
    {
        public void count()
        {
            int[] array = { 1, 2, 3, 2, 4, 3, 5, 1, 6, 1 };
            int duplicateCount = CountDuplicates(array);
            Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
        }

        private int CountDuplicates(int[] array)
        {
            Dictionary<int, int> elementCounts = new Dictionary<int, int>();
            int duplicateCount = 0;

            // Count the occurrences of each element
            foreach (int element in array)
            {
                if (elementCounts.ContainsKey(element))
                {
                    elementCounts[element]++;
                }
                else
                {
                    elementCounts[element] = 1;
                }
            }

            // Count the number of elements that appear more than once
            foreach (var count in elementCounts.Values)
            {
                if (count > 1)
                {
                    duplicateCount++;
                }
            }

            return duplicateCount;
        }
    }

   }
