using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCodeWinForm
{
    internal class CodeSymbol
    {
        public string X {  get; private set; } = "X";
        public string Y { get; private set; } = "Y";
        public string Z { get; private set; } = "Z";
        public string F { get; private set; } = "F";
        public string G { get; private set; } = "G";
    }
}
