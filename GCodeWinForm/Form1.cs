using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCodeWinForm
{
    public partial class Form1 : Form
    {
        private StartValues _row;
        private Generator _generator;

        private float _speed;
        private float _length;
        private float _depth;
        private float _step;
        private float _count;

        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_Speed;
            textBox2.TextChanged += textBox2_Length;
            textBox3.TextChanged += textBox3_Depth;
            textBox4.TextChanged += textBox4_Step;
            textBox5.TextChanged += textBox5_Count;

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";

            _generator = new Generator();
        }


        private void textBox1_Speed(object sender, EventArgs e)
        {
            TextBlock(ref _speed, textBox1);
        }

        private void textBox2_Length(object sender, EventArgs e)
        {
            TextBlock(ref _length, textBox2);
        }

        private void textBox3_Depth(object sender, EventArgs e)
        {
            TextBlock(ref _depth, textBox3);
        }

        private void textBox4_Step(object sender, EventArgs e)
        {
            TextBlock(ref _step, textBox4);
        }

        private void textBox5_Count(object sender, EventArgs e)
        {
            TextBlock(ref _count, textBox5);
        }

        private void button1_Generate(object sender, EventArgs e)
        {

            _row = new StartValues(_speed, _length, _depth, _step);

            SetName();

            _generator.CreateBlock(_row, _count);
            _generator.ShowCode();
        }

        private void TextBlock(ref float value, TextBox textBox)
        {
            try
            {
                value = float.Parse(textBox.Text);
            }
            catch
            {
                if (textBox.Text != "")
                {
                    MessageBox.Show("Не верный ввод!");
                    textBox.Text = "";
                }
            }
        }

        private void SetName()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            _generator.InputFileName(filename);
        }
    }
}
