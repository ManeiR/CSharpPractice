using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Program
    {

        static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int index = 0;
            foreach(int num in nums)
            {
                if(nums[index] != num)
                {
                    nums[++index] = num;
                }
            }
            return index + 1;


        }

        static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int rev = 0;
            int num = x;

            while (num != 0)
            {
                rev = (rev * 10) + (num % 10);
                num = num / 10;
             }

            return (x == rev);

        }

        static int[] MergeSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 && nums2.Length == 0)
                return new int[0];

            int count1 = nums1.Length;
            int count2 = nums2.Length;
            int[] arrayResult = new int[count1 + count2];

            int a = 0, b = 0; // indexes in origin arrays
            int i = 0;        // // index in result array

            //join till one of the array counts completed
            while (a < count1 && b < count2)
            {
                if (nums1[a] <= nums2[b])
                {
                    arrayResult[i++] = nums1[a++];
                }
                else
                    arrayResult[i++] = nums2[b++];
            }

            //add remaining elements
            if(a < count1)
            {
                for(int j = a; j < count1; j++)
                {
                    arrayResult[i++] = nums1[j];
                }
            }
            else
            {
                for(int j = b; j < count2; j++)
                {
                    arrayResult[i++] = nums2[j];
                }
            }

            return arrayResult;
        }

        static void Main(string[] args)
        {
            // RemoveDuplicates
            int[] nums = new int[] { 0, 0, 1, 1, 2, 2, 2, 5, 4, 4, 4, 4, 7, 7, 8, 10 };
            Console.WriteLine("Count of Actual Array is {0}", nums.Length);
            int count = RemoveDuplicates(nums);
            Console.WriteLine("Count with No Duplicate elements in Array is {0}", count);

            //IsPalindrome
            int x = 12321;
            if (IsPalindrome(x))
            {
                Console.WriteLine("{0} is a palindrome", x);
            }
            else
                Console.WriteLine("{0} is not a palindrome", x);

            //MergeSortedArrays
            int[] nums1 = new int[] { 0, 1, 2, 2, 5, 8, 8, 8};
            int[] nums2 = new int[] {4, 7, 7, 8, 10, 10 };
            int[] mergedSortedArray = MergeSortedArrays(nums1, nums2);
            Console.WriteLine("[{0}]", string.Join(",", mergedSortedArray));
        }
    }
}
