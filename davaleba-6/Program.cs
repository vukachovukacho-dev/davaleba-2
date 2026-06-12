namespace davaleba_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] scores =
        {
            new int[] { 90, 85, 88 },      
            new int[] { 75, 80 },          
            new int[] { 100, 95, 98, 92 }  
        };

            for (int i = 0; i < scores.Length; i++)
            {
                double sum = 0;

                for (int j = 0; j < scores[i].Length; j++)
                {
                    sum += scores[i][j];
                }

                double average = sum / scores[i].Length;

                Console.WriteLine($"სტუდენტი {i + 1}-ის საშუალო ქულაა: {average:F2}");
            }
        }
    }
}
