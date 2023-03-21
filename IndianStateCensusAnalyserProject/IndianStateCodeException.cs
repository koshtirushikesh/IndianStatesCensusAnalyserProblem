using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProject
{
    internal class IndianStateCodeException:Exception
    {
        public enum IndianStateCensusExcepctionType
        {
            INCORRECT_FILE_PATH,
        }

        public IndianStateCensusExcepctionType type;

        public IndianStateCodeException(IndianStateCensusExcepctionType type, string message): base(message)
        {
            this.type = type;
        }
    }
}
