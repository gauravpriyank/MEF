using MEF.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace MEF.ImportingLib
{
    public class Importer
    {
        [ImportMany(typeof(IContract),AllowRecomposition=true)]
        private IEnumerable<Lazy<IContract, MEF.Contract.IExportMetaData>> Imports { get; set; }
        
        public Importer()
        {
            var catalog = new AggregateCatalog();

            catalog.Catalogs.Add(new DirectoryCatalog(@"C:\Users\Gaurav\Documents\visual studio 2012\Projects\MEF\MEF.ImportingLib\Components"));

            var container = new CompositionContainer(catalog);

            container.ComposeParts(this);
             

        }

        public IEnumerable<IContract> GetComponets()
        {
            var x = Imports.Where(l => l.Metadata.JobType == JobType.Collection && l.Metadata.BrandName == BrandName.BrandY)
                           .Select(l => l.Value);

            return x;
                    
        }       
    }
}
