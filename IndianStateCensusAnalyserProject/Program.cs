using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stateCensusFilePath = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCensusData.csv";
            string stateCodeFilePath = "C:\\Users\\Rushi\\source\\repos\\IndianStatesCensusAnalyserProblem\\IndianStateCensusAnalyserProject\\Files\\StateCode.csv";
            
            CsvStateCences csvStateCences = new CsvStateCences();
            CsvStateCode csvStateCode = new CsvStateCode();
            csvStateCences.ReadCensusDeta(stateCensusFilePath);
            csvStateCode.ReadCodeData(stateCodeFilePath);

            Console.ReadLine();
        }
    }
}
