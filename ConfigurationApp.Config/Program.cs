using System;

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
