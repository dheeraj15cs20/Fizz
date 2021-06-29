using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fizz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
    public class FizzBuzzer
    {
        public string FizzBuzz(int input)
        {
            string result = string.Empty;
            if (input % 3 == 0 && input % 5==0)
            {
                result= "FizzBuzz";
            }
             else if (input % 5 == 0) 
            {
                result = "Buzz";

            }
            else if(input % 3 == 0)
            {
                result= "Fizz";
            }
            else
            { return input.ToString(); }
            return result;
            
        }
    }
}
  