namespace ArrayClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SortArray (unordered array)");
            int[] arrayExample = { 23, 13, 52, 9, 8, 3, 78 };

            foreach (int element in arrayExample)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Sequential array");
            Array.Sort(arrayExample);

            foreach (int element in arrayExample)
            {
                Console.WriteLine(element);
            }

            // Clear Array (Sets elements to zero starting from the specified index)
            // For example, Array.Clear(array, 3, 3) clears elements starting from index 3 to the next 3 elements.
            Console.WriteLine("----____ClearArray____----");
            Array.Clear(arrayExample, 3, 3);

            foreach (int element in arrayExample)
            {
                Console.WriteLine(element);
            }

            /* ReverseArray (It mirrors the elements of the array considering the middle. 
               It swaps the first element with the last element, or the second element with the second-to-last element, and so on.)*/
            Console.WriteLine("=====ArrayReverse=====");
            Array.Reverse(arrayExample);

            foreach (int element in arrayExample)
            {
                Console.WriteLine(element);
            }

            /* ArrayIndexOf (Returns the index of the given element in the array. 
               If the element is not found, it returns -1.) In this part, foreach is not used 
               because the index will be returned by the method itself, for example, it will iterate starting from 0 
               until it finds 9 and then returns the index (4 in this case). */
            Console.WriteLine("=====ArrayIndexOf=====");
            Console.WriteLine(Array.IndexOf(arrayExample, 9));

            // Array Resize is used to resize arrays.
            Console.WriteLine("-_-_-_Array Resize_-_-_");
            Array.Resize<int>(ref arrayExample, 8); // ref: reference <int>: type

            arrayExample[7] = 99; // Assigning a value to the 8th element in the 7-element array.

            foreach (int element in arrayExample)
            {
                Console.WriteLine(element);
            }
        }
    }
}
