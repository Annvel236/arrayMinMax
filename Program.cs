using System;
using System.Linq;

namespace arrayMinMax
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int[] xArray = new int[50];

      for(int i = 0; i < xArray.Length; i++){
        int elem = random.Next(1, 101);
        xArray[i] = elem ;
      }

      // for(int i = 0; i < xArray.Length; i++){
      //   Console.Write($"{xArray[i]} ");
      // }
      // Console.WriteLine("\n");

      Console.WriteLine($"Max: {xArray.Max()}, Min: {xArray.Min()}");
      
    }
  }
}
