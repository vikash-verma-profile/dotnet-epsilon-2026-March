using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class SampleFile
    {
        public SampleFile()
        {
                
        }
        ~ SampleFile()
        {

        }
    }
    class SampleImplemation : IDisposable
    {
        bool isDisposing = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                if(disposing)
                {
                    //
                }
                isDisposing = false;
            }
        }

        ~SampleImplemation()
        {
            Dispose(true);
        }
    }
    internal class SampleExampe
    {

        public static void Main()
        {
            SampleImplemation sample=new SampleImplemation();
            sample.Dispose();

        }
    }
}
