using IndianStateCensusAnalyserProject;

namespace IndianStateCensusAnalyserProjectTest
{
    public class Tests
    {
        string stateCensusFilePath = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCensusData.csv";
       
        CsvStateCences csvStateCensus = new CsvStateCences();
        
        [Test]
        public void GivenStateCensusData_ShouldMatchNumberOfReturnMatch()
        {
            Assert.AreEqual( 29, csvStateCensus.ReadCensusDeta(stateCensusFilePath));
        }
    }
}