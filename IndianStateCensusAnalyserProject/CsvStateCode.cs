using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace IndianStateCensusAnalyserProject
{
    public class CsvStateCode
    {
        public int ReadCodeData(string filePath)
        {
            if (!File.Exists(filePath))
                throw new IndianStateCodeException(IndianStateCodeException.IndianStateCensusExcepctionType.INCORRECT_FILE_PATH, "File Path is Incorrect");

            if (!filePath.EndsWith(".csv"))
                throw new IndianStateCodeException(IndianStateCodeException.IndianStateCensusExcepctionType.INCORRECT_FILE_TYPE, "File Type is Incorrect");

            var header = File.ReadAllLines(filePath);
            if (header[0].Contains("/"))
                throw new IndianStateCodeException(IndianStateCodeException.IndianStateCensusExcepctionType.INCORRECT_FILE_DELIMITER, "File Delimiter is Incorrect");

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCodeAnalyserModel>().ToList();

                foreach (var record in records)
                {
                    // SrNo,State,Name,TIN,StateCode 
                    Console.WriteLine($"{record.SrNo} {record.StateName} {record.TIN} {record.StateCode} ");
                }
                return records.Count();
            }
        }

        public bool CheckStateCodeHeader(string filePath, string expectedHeader)
        {
            var header = File.ReadAllLines(filePath);
            if (header[0].Equals(expectedHeader))
                return true;
            else
                throw new IndianStateCodeException(IndianStateCodeException.IndianStateCensusExcepctionType.INCORRECT_FILE_HEADER, "File Header is Incorrect");
        }
    }
}
