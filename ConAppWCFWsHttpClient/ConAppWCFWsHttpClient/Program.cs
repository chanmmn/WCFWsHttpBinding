using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client service1 = new ServiceReference1.Service1Client();
            string result = service1.GetData(10);
            Console.WriteLine(result);
        }
    }
}
