namespace GCodeWinForm
{
    internal class BlockMidle
    {
        public BlockMidle(CodeSymbol symbol, MidleValues midle, float yPosition, float depth)
        {
            Midle = $"{symbol.F}{midle.SpeedOfTransition} {symbol.X}{0} {symbol.Y}{yPosition} {symbol.Z}{0}\n" +
                    $"{symbol.F}{midle.SpeedOfDepth} {symbol.X}{0} {symbol.Y}{yPosition} {symbol.Z}{depth}\n" +
                    $"{symbol.F}{midle.MainSpeed} {symbol.X}{midle.MainDistance} {symbol.Y}{yPosition} {symbol.Z}{depth}\n" +
                    $"{symbol.F}{midle.MidleSpeed} {symbol.X}{midle.MidleDistance} {symbol.Y}{yPosition}  {symbol.Z} {depth}\n" +
                    $"{symbol.F}{midle.LastSpeed} {symbol.X}{midle.LastDistance}  {symbol.Y}{yPosition}  {symbol.Z}{depth}\n" +
                    $"{symbol.F}{midle.SpeedOfDepth} {symbol.X}{midle.LastDistance} {symbol.Y}{yPosition} {symbol.Z}{0}\n";
        }

        public string Midle { get; private set; }
    }
}
