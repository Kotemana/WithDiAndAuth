using ProjectBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Services
{
    public class TestServiceNew : ITestService
    {
        public string Test()
        {
            return "HelloWorld";
        }

        public string SuperTest()
        {
            return "SuperHelloWorld";
        }
    }
}
