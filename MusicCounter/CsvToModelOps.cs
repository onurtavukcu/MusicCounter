using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MusicCounter
{
    public class CsvToModelOps
    {
        public List<PlayerModel> csvToData()
        {
            var fileLocation = @"C:\Users\adm\Desktop\exhibitA-input.csv";
            using (var reader = new StreamReader($@"{fileLocation}"))
            {
                List<PlayerModel> modelList = new List<PlayerModel>();

                reader.SkipLine(1);

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

                    var modelIns = new PlayerModel();
                    modelIns.PLAY_ID = values[0];
                    modelIns.SONG_ID = Int16.Parse(values[1]);
                    modelIns.CLIENT_ID = Int16.Parse(values[2]);
                    modelIns.PLAY_TS = DateTime.Parse(values[3]);
                    modelList.Add(modelIns);
                }
                return modelList;
            }
        }
    }
}