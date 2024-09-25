namespace array.work4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("davaleba 1");
            int[] array = { 1, 2, 3, 4, 5, 4 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);



            Console.WriteLine("davaleba 2");

            int[] fullArray = [1, 2, 3, 4, 5, 6];
            int[] emptyArray = new int[fullArray.Length];

            Console.WriteLine($"New array :");
            for (int i = 0; i < fullArray.Length; i++)
            {
                emptyArray[i] += fullArray[i];
                Console.WriteLine($"{emptyArray[i]}");
            }

            Console.WriteLine("davaleba 3");

            int[] arrayNumbers = { 1, 3, 2, 3, 4, 3, 2, 5, 6, 5 };
            bool unique;

            Console.WriteLine("Unique number:");

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                unique = true;

                for (int j = 0; j < arrayNumbers.Length; j++)
                {
                    if (i != j && arrayNumbers[i] == arrayNumbers[j])
                    {
                        unique = false;
                        break;
                    }
                }

                if (unique)
                {
                    Console.WriteLine(arrayNumbers[i]);
                }
            }



            Console.WriteLine("davaleba 4");

            int[] numberArray = [1, 5, 18, 2, 9, 7, 3, 10];
            int max = numberArray[0];
            for (int i = 1; i < numberArray.Length; i++)
            {
                if (numberArray[i] > max)
                {
                    max = numberArray[i];
                }
            }
            Console.WriteLine(max);

            Console.WriteLine("davaleba 5");

            int[] indexArrayNumber = [1, 5, 18, 2, 9, 7, 20, 10, 13];
            int index = 0;

            for (int i = 1; i < indexArrayNumber.Length; i++)
            {
                if (indexArrayNumber[i] > indexArrayNumber[index])
                {
                    index = i;
                }
            }

            Console.WriteLine($"index: {index}");

            Console.WriteLine("davaleba 6");

            string[] names = ["nika", "giorgi", "elene", "daviTi"];

            Console.Write("Enter number (0 - 4): ");
            int n = int.Parse(Console.ReadLine());


            if (n < 0 || n > names.Length)
            {
                Console.WriteLine($"Enter valid number ");
            }
            else
            {
                Console.WriteLine("reversed : ");
                for (int i = n - 1; i >= 0; i--)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
