using IndianStateCensusAnalyserProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProjectTest
{
    internal class StateCodeTestCase
    {
        string stateCodeFilePath = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCode.csv";
        string stateCodeFile_IncorectPath = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCodee.csv";
        
        CsvStateCode csvStateCode = new CsvStateCode();

        [Test]
        public void GivenStatesCodeCSVfile_AnalysedShouldReturnMatchesNumberOfRecord()
        {
            Assert.AreEqual(37, csvStateCode.ReadCodeData(stateCodeFilePath));
        }

        [Test]
        public void GivenIncorrectStatesCodeCSVfile_ShouldThrowCustomeIncorectPathException()
        {
            try
            {
                csvStateCode.ReadCodeData(stateCodeFile_IncorectPath);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("File Path is Incorrect", ex.Message);
            }
        }
    }
}
