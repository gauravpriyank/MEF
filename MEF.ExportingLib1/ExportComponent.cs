using MEF.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.ExportingLib1
{
    [Export(typeof(IContract))]
    [ExportMetaData(JobType.Collection,BrandName.BrandX)]
    public class ExportComponent : IContract
    {

        public void DoSomething()
        {
            Console.WriteLine("Message from ExportingLib1");
        }
    }
}
