using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCodeWinForm
{
    internal class Block
    {
        public Block(CodeSymbol symbol, StartValues value, float yPosition) 
        {
           CodePart = $"{symbol.F}{500} {symbol.X}{0} {symbol.Y}{yPosition} {symbol.Z}{0}\n" +
                    $"{symbol.F}{50} {symbol.X}{0} {symbol.Y}{yPosition} {symbol.Z}{value.Depth}\n" +
                    $"{symbol.F}{value.Speed} {symbol.X}{value.Length} {symbol.Y}{yPosition} {symbol.Z}{value.Depth}\n");
        }

        public string CodePart { get; set; }
    }
}
