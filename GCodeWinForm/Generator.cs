using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCodeWinForm
{
    internal class Generator
    {
        private CodeSymbol _block = new CodeSymbol();
        private string _path = "test.txt";

        public async void CreateBlock(StartValues value, float count)
        {
            float yPosition = 0;

            for (int i = 0; i < count; i++) 
            {
                StringBuilder block = new StringBuilder( $"{_block.F}{500} {_block.X}{0} {_block.Y}{yPosition} {_block.Z}{0}\n" +
                    $"{_block.F}{50} {_block.X}{0} {_block.Y}{yPosition} {_block.Z}{value.Depth}\n" +
                    $"{_block.F}{value.Speed} {_block.X}{value.Length} {_block.Y}{yPosition} {_block.Z}{value.Depth}\n");

                string blockString = block.ToString();

                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    if(i <= 0)
                        writer.WriteLine($"{_block.G}{1}");

                    await writer.WriteLineAsync(blockString);
                }

                yPosition += value.Step;
            }
        }

        public void ShowCode()
        {
            using (StreamReader reader = new StreamReader(_path))
            {
                string text = reader.ReadToEnd();
                MessageBox.Show(text);
            }
        }

        public void InputFileName(string filename)
        {
            _path = filename;
        }
    }
}
