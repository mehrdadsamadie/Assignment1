using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();
            var arr = input.Split('+');
            int result = 0;
            if (arr.Length >= 2)
            {
                foreach (var item in arr)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        try
                        {
                            result += int.Parse(item);
                        }
                        catch { Console.WriteLine("the one of Operation is Invalid !"); return; }
                    }
                    else
                    {
                        Console.WriteLine("the one of Operation is Invalid !"); return;
                    }
                }
                Console.WriteLine(result);
                return;
            }
            else
            {
                Console.WriteLine("more than one Operation is valid !!"); return;
            }
        }
    }
}
