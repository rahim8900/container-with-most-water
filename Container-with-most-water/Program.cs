using System;
namespace Container_with_most_water
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(',');
            int max = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if(i != j)
                    {
                         int area = Math.Min(int.Parse(input[i]), int.Parse(input[j])) * Math.Abs(i-j);
                        if(area > max)
                        {
                            max = area;
                        }
                    }                    
                }                
            }

            Console.WriteLine(max);
        }
    }
}
