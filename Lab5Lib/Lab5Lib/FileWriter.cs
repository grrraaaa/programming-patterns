using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Lib
{
    public class FileWriter : IWriter
    {
        string filename = Constant.FileName;
        public string Filename { get { return this.filename; } }
        public FileWriter(string? filename = null)
        {
            this.filename = filename ?? Constant.FileName;
        }
        public string? Save(string massage)
        {
          File.WriteAllText(filename, massage);
          return this.filename;
        }
    }
}
