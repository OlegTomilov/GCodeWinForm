using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GCodeWinForm
{
    internal class Generator
    {
        private CodeSymbol _symbol = new CodeSymbol();
        private StringBuilder _block;
        private string _path = "test.txt";

        public void CreateSimpleBlock(float count, SimpleValues simple)
        {
            float yPosition = 0;

            for (int i = 0; i < count; i++)
            {
                BlockSimple block = new BlockSimple(_symbol, simple, yPosition);

                _block = new StringBuilder(block.Simple);
                string blockString = _block.ToString();
                WriteBlock(i, blockString);

                yPosition += simple.Step;
            }
        }

        public void CreateMideleBlock(float count, MidleValues midle)
        {
            float yPosition = 0;

            for (int i = 0; i < count; i++)
            {
                float depth = midle.Depth;

                for (int j = 0; j < midle.CountOfDepth; j++)
                {
                    BlockMidle block = new BlockMidle(_symbol, midle, yPosition, depth);

                    _block = new StringBuilder(block.Midle);
                    string blockString = _block.ToString();
                    WriteBlock(i, blockString, j);

                    depth += midle.Depth;
                }

                yPosition += midle.Step;
            }
        }

        public void ShowCode()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_path))
                {
                    string text = reader.ReadToEnd();
                    MessageBox.Show(text);
                }
            }
            catch
            {
                MessageBox.Show("Файл не создан!", "Супервнимание!!!");
            }
        }

        public void InputFileName(string filename)
        {
            _path = filename;
        }

        private async void WriteBlock(int i, string block, int j = 2)
        {
            using (StreamWriter writer = new StreamWriter(_path, true))
            {
                if (i <= 0 && j <= 0)
                    writer.WriteLine($"{_symbol.G}{1}");

                await writer.WriteLineAsync(block);
            }
        }
    }
}
