using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    public enum SampleTypes     //Holds the various sample types that can be added to a well
    {
        pos,            //Regular sample
        controlNeg,     //Negative control sample
        controlPos      //Positive control sample
    }
}
