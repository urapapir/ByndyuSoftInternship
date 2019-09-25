using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {

            // int[] arr = {2147483647, 99999};
            int[] arr = null;
            try
            {
                int sum = Byndyusoft.GetSumOfMins(ref arr);
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            throw;
            }
            Console.ReadKey();
         }
    }
     
}
