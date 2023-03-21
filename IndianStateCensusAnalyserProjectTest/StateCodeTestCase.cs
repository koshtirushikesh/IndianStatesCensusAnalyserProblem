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
        string stateCodeFile_IncorectType = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCode.txt";
        string stateCodeFile_IncorectDelimiter = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCode - Copy.csv";
        string stateCodeFile_IncorectHeader_FilePath = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCode - Copy (2).csv";

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

        [Test]
        public void GivenCorrectStatesCodefile_ButIncorrectFileType_ShouldThrowCustomeIncorectTypeException()
        {
            try
            {
                csvStateCode.ReadCodeData(stateCodeFile_IncorectType);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("File Type is Incorrect", ex.Message);
            }
        }

        [Test]
        public void GivenCorrectStatesCodeCsvfile_ButIncorrectFileDelimiter_ShouldThrowCustomeIncorectDelimiterException()
        {
            try
            {
                csvStateCode.ReadCodeData(stateCodeFile_IncorectDelimiter);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("File Delimiter is Incorrect", ex.Message);
            }
        }

        [Test]
        public void GivenCorrectStatesCodeCsvfile_ButIncorrectFileHeader_ShouldThrowCustomeIncorectHeaderException()
        {
            try
            {
                string expectedHeader = "SrNo,StateName,TIN,StateCode";
                csvStateCode.CheckStateCodeHeader(stateCodeFile_IncorectHeader_FilePath,expectedHeader);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("File Header is Incorrect", ex.Message);
            }
        }
    }
}
