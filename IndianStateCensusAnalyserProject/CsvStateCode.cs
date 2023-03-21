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
    public class CsvStateCode
    {
        public int ReadCodeData(string filePath)
        {
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
    }
}
