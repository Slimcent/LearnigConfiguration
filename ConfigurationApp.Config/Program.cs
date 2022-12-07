using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationApp.Config
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var value = System.Configuration.ConfigurationSettings.AppSettings["key"];

            Console.WriteLine(value);
        }
    }
}
