using IndianStateCensusAnalyserProject;

namespace IndianStateCensusAnalyserProjectTest
{
    public class Tests
    {
        string stateCensusFilePath = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCensusData.csv";
        string stateCensusFilePathIncorrect = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCensusDataa.csv";
        string stateCensusFileTypeIncorrect = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCensusData - Copy (2).json";
        string stateCensusFileHeaderIncorrect = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCensusData - Copy.csv";
        string stateCensusFileDelimiterIncorrect = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCensusData - Copy.csv";

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
        public void GivenIncorrectFileType_ShouldReturnCustomeException()
        {
            try
            {
                csvStateCensus.ReadCensusDeta(stateCensusFileTypeIncorrect);
            }
            catch (IndianStateCensusExcepction ex)
            {
                Assert.AreEqual("Incorrect file Type", ex.Message);
            }
        }

        [Test]
        public void GivenIncorrectDelimeter_ShouldReturnCustomeException()
        {
            try
            {
                csvStateCensus.ReadCensusDeta(stateCensusFileDelimiterIncorrect);
            }
            catch (IndianStateCensusExcepction ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }

        [Test]
        public void GivenIncorrectHeader_ShouldReturnCustomeException()
        {
            try
            {
                string Header = "State,Population,AreaInSqKm,DensityPerSqKm";
                csvStateCensus.ReadStateCensusData(stateCensusFileHeaderIncorrect, Header);
            }
            catch (IndianStateCensusExcepction ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}