using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProject
{
    public class CsvStateCences
    {
<<<<<<< HEAD
        public int ReadCensusDeta(string filePath)
=======
        public void ReadCensusData(string filePath)
>>>>>>> UC2_loadStatesCodeData
        {
            if (!File.Exists(filePath))
            {
                throw new IndianStateCensusExcepction(IndianStateCensusExcepction.IndianStateCensusExcepctionType.INCORRECT_FILE, "Incorrect file Path");
            }
            if (!filePath.EndsWith(".csv"))
            {
                throw new IndianStateCensusExcepction(IndianStateCensusExcepction.IndianStateCensusExcepctionType.INCORRECT_TYPE, "Incorrect file Type");
            }

            var csvfile = File.ReadAllLines(filePath);
            string header = csvfile[0];

            if (header.Contains("/"))
            {
                throw new IndianStateCensusExcepction(IndianStateCensusExcepction.IndianStateCensusExcepctionType.INCORRECT_DELIMETER, "Incorrect Delimiter");
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCensusAnalyserModel>().ToList();

                foreach(var record in records)
                {
                    Console.WriteLine($"{record.State} {record.Population} {record.AreaInSqKm} {record.DensityPerSqKm}");
                }
                return records.Count();
            }
        }

        public bool ReadStateCensusData(string filePath, string actualHeader)
        {
            var csvfile = File.ReadAllLines(filePath);
            string header = csvfile[0];

            if (!header.Equals(actualHeader))
                return true;
            else
                throw new IndianStateCensusExcepction(IndianStateCensusExcepction.IndianStateCensusExcepctionType.INCORRECT_DELIMETER, "Incorrect Header");

        }
    }
}
