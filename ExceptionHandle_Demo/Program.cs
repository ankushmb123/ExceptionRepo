using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle_Demo
{
    public class Program
    {
        private static int choice;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the below option");
                Console.WriteLine("1-TryCatch");
                Console.WriteLine("2-Custom Exception");
                Console.WriteLine("----------------------");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        HandleException handleException = new HandleException();
                        handleException.Display();
                        Console.ReadLine();
                        break;
                    case 2:
                        DivideByZero_Exception divideByZero_Exception = new DivideByZero_Exception();
                        divideByZero_Exception.Custom();
                        break;
                }
            }
        }
    }
}
