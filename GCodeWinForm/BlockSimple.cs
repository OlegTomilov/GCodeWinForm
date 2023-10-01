namespace GCodeWinForm
{
    internal class BlockSimple
    {
        public BlockSimple(CodeSymbol symbol, SimpleValues simple,  float yPosition) 
        {
           Simple = $"{symbol.F}{500} {symbol.X}{0} {symbol.Y}{yPosition} {symbol.Z}{0}\n" +
                    $"{symbol.F}{50} {symbol.X}{0} {symbol.Y}{yPosition} {symbol.Z}{simple.Depth}\n" +
                    $"{symbol.F}{simple.Speed} {symbol.X}{simple.Length} {symbol.Y}{yPosition} {symbol.Z}{simple.Depth}\n" +
                    $"{symbol.F}{50} {symbol.X}{simple.Length} {symbol.Y}{yPosition} {symbol.Z}{0}\n";
        }

        public string Simple { get; private set; }
    }
}
