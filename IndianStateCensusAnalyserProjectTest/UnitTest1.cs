using IndianStateCensusAnalyserProject;

namespace IndianStateCensusAnalyserProjectTest
{
    public class Tests
    {
        string stateCensusFilePath = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCensusData.csv";
        string stateCensusFilePathIncorrect = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCensusDataa.csv";
       
        CsvStateCences csvStateCensus = new CsvStateCences();
        
        [Test]
        public void GivenStateCensusData_ShouldMatchNumberOfReturnMatch()
        {
            Assert.AreEqual( 29, csvStateCensus.ReadCensusDeta(stateCensusFilePath));
        }

        [Test]
        public void GivenIncorrectFilePath_ShouldReturnCustomeException()
        {
            try
            {
                csvStateCensus.ReadCensusDeta(stateCensusFilePathIncorrect);
            }
            catch (IndianStateCensusExcepction ex)
            {
                Assert.AreEqual("Incorrect file Path", ex.Message);
            }
        }

        [Test]
        public void GivenIncorrectFiletype_ShouldReturnCustomeException()
        {
            try
            {
                csvStateCensus.ReadCensusDeta(stateCensusFilePath);
            }
            catch (IndianStateCensusExcepction ex)
            {
                Assert.AreEqual("Incorrect file type", ex.Message);
            }
        }
    }
}