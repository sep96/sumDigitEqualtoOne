using System;
using System.Collections.Generic;
using System.Linq;

namespace sumDigitEqualtoOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numList = new List<double>() { 0.25, 0.3, 0.24, 0.21 }; // Sum numList equl to 1
            double newnumber = 0.5; // want to change 0.25 to 0.5 
            int numIndex = 0; //index Number wants to change
            var result = Changenum(numList, newnumber, numIndex);
            foreach (var num in result)
                System.Console.WriteLine(num);
            System.Console.WriteLine("sum of numList equals to: " + result.Sum());
            System.Console.ReadLine();
        }


        static List<double> Changenum(List<double> numbers , double chnagedNumber , int index)
        {
            double diffrence = numbers[index] - chnagedNumber;
            double sumNumbers = numbers.Sum() - numbers[index] ;
            for (int i = 0; i < numbers.Count; i++)
            {
                if(i != index)
                {
                    numbers[i] = ( (numbers[i] * (diffrence)) / sumNumbers  ) + numbers[i];
                }
            }
            numbers[index] = chnagedNumber;
            return numbers;
        }

    }
}
