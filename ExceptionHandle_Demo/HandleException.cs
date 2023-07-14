using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle_Demo
{

    public class HandleException
    {
        public void Display()
        {
            try
            {
                //Code to try block goes here
                //put a statement where we want to raise exception 
                int[] ints = { 1, 2, 3 };
                for (int val = 0; val < ints.Length; val++)
                {
                    Console.WriteLine(ints[val]);
                }
                Console.WriteLine(ints[10]);

            }
            catch (Exception ex) //somespecificexception
            {
                //statement to handle the exception goes here 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //statement to execute after try and posibily catch block
                //cleanup Code
            }

        }
    }
}
