using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ExceptionTest();
        Console.Read();
    }
    private static void ExceptionTest()
    {
        try
        {
            int j = 0;
            int i = 5;
            i = 1 / j;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            var stList = ex.StackTrace.ToString().Split('\\');
            Console.WriteLine("Exception occurred at " + stList[stList.Count() - 1]);
        }
    }
}