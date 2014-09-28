using MEF.ImportingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var components = new Importer().GetComponets();

            foreach (var component in components)
            {
                component.DoSomething();
            }
            
            Console.ReadLine();

        }
    }
}
