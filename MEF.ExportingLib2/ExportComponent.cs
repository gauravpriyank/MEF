using MEF.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.ExportingLib2
{
    [Export(typeof(IContract))]
    [ExportMetaData(JobType.Collection, BrandName.BrandY)]
    public class ExportComponent : IContract
    {
        public void DoSomething()
        {
            Console.WriteLine("Message from ExportingLib2");
        }
    }
}
