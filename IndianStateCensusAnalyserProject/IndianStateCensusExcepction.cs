using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProject
{
    public class IndianStateCensusExcepction:Exception
    {
        public enum IndianStateCensusExcepctionType
        {
            INCORRECT_FILE,
            INCORRECT_TYPE
        }
        public IndianStateCensusExcepctionType type;
        public IndianStateCensusExcepction(IndianStateCensusExcepctionType type,string message):base(message)
        {
            this.type = type;
        }
    }
}
