using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 3, 8, 4, 2 };
        int target = 4;
        int index = LinearSearch(arr, target);

        if (index != -1)
        {
            Console.WriteLine("Element found at index: " + index);
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
    }

    public static int LinearSearch<T>(T[] arr, T target, IComparer<T> comparer = null) where T : IComparable
    {
        if (comparer == null)
        {
            comparer = Comparer<T>.Default;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (comparer.Compare(arr[i], target) == 0)
            {
                return i;
            }
        }

        return -1;
    }
}