using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessorDI {
    //P363 問題15.1
    public class LineToHalfNumberService : ITextFileService {
        public void Initilize(string fname) {
        }

        public void Execute(string line) {
            string result = new string(line.Select(c => 
            ('０' <= c && c <= '９') ? (char)(c - '０' + '0') : c).ToArray());
            Console.WriteLine(result);
        }

        public void Terminate() {
            
        }
    }
}
