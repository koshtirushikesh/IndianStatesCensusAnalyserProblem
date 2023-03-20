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
            CsvStateCences csvStateCences = new CsvStateCences();
            csvStateCences.ReadCensusDeta(stateCensusFilePath);

            Console.ReadLine();
        }
    }
}
