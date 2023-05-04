using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCounter
{
    //public class SkippedReader : StreamReader
    //{
    //    public SkippedReader(string path) : base(path){}

    //    public void SkippedLine(int lineCount)
    //    {
    //        for (int i = 0; i < lineCount; i++)
    //        {
    //            this.ReadLine();
    //        }
    //    }
    //}

    public static class StreamReaderExtensions
    {
        public static void SkipLine(this StreamReader reader, int lineCount)
        {
            for (int i = 0; i < lineCount; i++)
            {
                reader.ReadLine();
            }
        }
    }
}
