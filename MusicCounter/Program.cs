using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var csvInstance = new CsvToModelOps();
            var listOfPlayerOnModel = csvInstance.csvToData();

            var groupingInstance = new GroupToDataByDateOps();
            groupingInstance.GroupingData(listOfPlayerOnModel);

            Console.ReadLine();
        }
    }
}
