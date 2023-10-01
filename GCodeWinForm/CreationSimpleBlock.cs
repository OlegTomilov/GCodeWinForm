using System;
using System.Windows.Forms;

namespace GCodeWinForm
{
    public partial class CreationSimpleBlock : Form
    {
        private SimpleValues _block;
        private Generator _generator;

        private float _speed;
        private float _length;
        private float _depth;
        private float _step;
        private float _count;

        public CreationSimpleBlock()
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

            _block = new SimpleValues(_speed, _length, _depth, _step);

            SetName();

            _generator.CreateSimpleBlock(_count, _block);
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
                if (textBox.Text != "" && textBox.Text != "-")
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

        private void button2_Click(object sender, EventArgs e)
        {
            FasterBlock fasterBlock = new FasterBlock();
            fasterBlock.Show();
        }

        private void button3_Example(object sender, EventArgs e)
        {
            ExampleImage exampleImage = new ExampleImage();
            exampleImage.Show();
            exampleImage.ChangeBackgroundPicture(0);
        }
    }
}
