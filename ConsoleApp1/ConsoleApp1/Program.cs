using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");

             Console.WriteLine("1-ci ededi daxil et");
             string input = Console.ReadLine();
             int number = Convert.ToInt32(input);

             if (number % 3 == 0 && number % 7 == 0)
             {
                 Console.WriteLine("bolunur");

             }
             else
             {
                 Console.WriteLine("bolunmur");
             }*/
            /*Console.WriteLine("1-ci edidi daxil et");
            string input1 = Console.ReadLine();
            int n1 = Convert.ToInt32(input1);

            Console.WriteLine("2-ci ededi daxil et");
            string input2 = Console.ReadLine();
            int n2 = Convert.ToInt32(input2);

            int sum=0;

            if (n1 % 2 == 0 && n2 % 2 == 0)

            {
                sum = n1 + n2;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("cut deyil");
            }*/
            /*
                        Console.WriteLine("1-ci edidi daxil et");
                        string input1 = Console.ReadLine();
                        int n1 = Convert.ToInt32(input1);

                        Console.WriteLine("2-ci ededi daxil et");
                        string input2 = Console.ReadLine();
                        int n2 = Convert.ToInt32(input2);

                        int count = 0;
                        for (int i = n1; i < n2; i++)
                        {
                            if(i % 2 != 0)
                            {
                                count++;

                            }

                        }    
                        Console.WriteLine(count);*/
            /* var sum = 0;
             int[] numbers = { 1, 2, 3, 4, 5 };

             for (int i = 0; i < numbers.Length; i++)
             {
                 if(numbers[i] % 2 == 0)
                 {

                     sum += numbers[i];
                 }

             }
             Console.WriteLine(sum);*/
            var sum = 0;
            int[] numbers = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 2; j < numbers[i]; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        sum += numbers[i];
                        break;

                    }


                }

                      

            }
            Console.WriteLine(sum);
        }
    }
}
