using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lianxi
{
    class Class1
    {
        
        static void Main(string[] args)
        {
            server ss = new server();
            ss.Start("127.0.0.1", 1234);
            while (true)
            {
                string str = Console.ReadLine();
                switch (str)
                {
                    case "quit":return;
                }
            }


        }
    }
}
