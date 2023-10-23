namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 7, 16, 5, 9 };
            int[] reverseArray = ReverseArray(Array);

            Console.WriteLine("Array: " + string.Join(", ", Array));
            Console.WriteLine("Ters Array: " + string.Join(", ", reverseArray));
        }

        static int[] ReverseArray(int[] array)
        {
            int[] reverse = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reverse[i] = array[array.Length - 1 - i];
            }

            return reverse;
        }
    }
}
    