namespace davaleba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 7, 3 };          
            int[] array2 = { 4, 5, 6 };
        
            int[] resultArray = new int[array1.Length + array2.Length];
           
            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i];
            }

            
            for (int i = 0; i < array2.Length; i++)
            {
                resultArray[array1.Length + i] = array2[i];
            }

            
            Console.Write("result = [");

            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i]);

                if (i < resultArray.Length - 1)
                    Console.Write(", ");
            }
                Console.WriteLine("]");
        }
    }
}
