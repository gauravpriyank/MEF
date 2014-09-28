using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace MEF.Contract
{    
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false),MetadataAttribute]
    public class ExportMetaDataAttribute : ExportAttribute, IExportMetaData
    {       
        public ExportMetaDataAttribute(JobType jobtype, BrandName brandName)            
        {
            JobType = jobtype;
            BrandName = brandName;
        }

        public JobType JobType { get; private set; }

        public BrandName BrandName { get; private set; }
    }

    public interface IExportMetaData
    {
        JobType JobType { get; }
        BrandName BrandName { get; }
    }

    public enum JobType
    { 
        Collection,
        Comparision,
        Correction
    }

    public enum BrandName
    {
        BrandX,
        BrandY,
        BrandZ
    }
}
