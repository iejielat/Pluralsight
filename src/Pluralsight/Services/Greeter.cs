using Microsoft.Extensions.Configuration;
using Pluralsight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pluralsight.Services
{
    public interface IGreeter
    {
        string GetGreeting();
    }
    public class Greeter : IGreeter
    {
        private string _greeting;

        public Greeter(IConfiguration config)
        {
            _greeting = config["greeting"];
        }
        public string GetGreeting()
        {
            return _greeting;
        }
    }
}
    

