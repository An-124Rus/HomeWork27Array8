internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 0;
        int maxValue = 10;

        Console.WriteLine("Введите количество чисел в цикле: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();

        int[] array = new int[arrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minValue, maxValue);

            Console.Write(array[i] + " ");
        }

        Console.WriteLine("\nВведите значение сдвига цикла: ");
        int userShift = Convert.ToInt32(Console.ReadLine());

        for(int j = 0; j < userShift; j++)
        {
            int temporaryNumber = array[0];

            for (int i = 1; i <= array.Length; i++)
            {
                if (i != array.Length)
                    array[i - 1] = array[i];
                else
                    array[array.Length - 1] = temporaryNumber;
            }
        }

        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
    }
}