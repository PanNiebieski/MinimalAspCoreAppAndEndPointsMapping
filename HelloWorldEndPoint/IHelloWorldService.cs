using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldEndPointProject
{
    public interface IHelloWorldService
    {
        public string SayHello(string user);
    }
}
