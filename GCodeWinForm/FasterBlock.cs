using System;
using System.Windows.Forms;

namespace GCodeWinForm
{
    public partial class FasterBlock : Form
    {
        private MidleValues _block;
        private Generator _generator;

        private float _depth;
        private float _step;
        private float _speedOfDepth;
        private float _speedOfTransition;
        private float _mainDistance;
        private float _midleDistance;
        private float _lastDistance;
        private float _mainSpeed;
        private float _midleSpeed;
        private float _lastSpeed;
        private float _countOfDepth;
        private float _count;

        public FasterBlock()
        {
            InitializeComponent();

            textBox1.TextChanged += textBox1_MainSpeed;
            textBox2.TextChanged += textBox2_MainDistance;
            textBox1.TextChanged += textBox3_MildeSpeed;
            textBox1.TextChanged += textBox4_MidleDistance;
            textBox1.TextChanged += textBox5_LastSpeed;
            textBox1.TextChanged += textBox10_LastDistance;
            textBox1.TextChanged += textBox6_CountOfDepth;
            textBox1.TextChanged += textBox11_Depth;
            textBox1.TextChanged += textBox12_Step;
            textBox1.TextChanged += textBox8_Count;
            textBox1.TextChanged += textBox14_SpeedOfDepth;
            textBox1.TextChanged += textBox9_SpeedOfTransition;

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";

            _generator = new Generator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _block = new MidleValues(_depth, _step, _speedOfDepth, _speedOfTransition, _mainDistance, _midleDistance, _lastDistance, _mainSpeed, _midleSpeed, _lastSpeed, _countOfDepth);

            SetName();

            _generator.CreateMideleBlock(_count, _block);
            _generator.ShowCode();
        }

        private void textBox1_MainSpeed(object sender, EventArgs e)
        {
            TextBlock(ref _mainSpeed, textBox1);
        }

        private void textBox2_MainDistance(object sender, EventArgs e)
        {
            TextBlock(ref _mainDistance, textBox2);
        }

        private void textBox3_MildeSpeed(object sender, EventArgs e)
        {
            TextBlock(ref _midleSpeed, textBox3);
        }

        private void textBox4_MidleDistance(object sender, EventArgs e)
        {
            TextBlock(ref _midleDistance, textBox4);
        }

        private void textBox5_LastSpeed(object sender, EventArgs e)
        {
            TextBlock(ref _lastSpeed, textBox5);
        }

        private void textBox10_LastDistance(object sender, EventArgs e)
        {
            TextBlock(ref _lastDistance, textBox10);
        }

        private void textBox6_CountOfDepth(object sender, EventArgs e)
        {
            TextBlock(ref _countOfDepth, textBox6);
        }

        private void textBox11_Depth(object sender, EventArgs e)
        {
            TextBlock(ref _depth, textBox11);
        }

        private void textBox12_Step(object sender, EventArgs e)
        {
            TextBlock(ref _step, textBox12);
        }

        private void textBox8_Count(object sender, EventArgs e)
        {
            TextBlock(ref _count, textBox8);
        }

        private void textBox14_SpeedOfDepth(object sender, EventArgs e)
        {
            TextBlock(ref _speedOfDepth, textBox14);
        }

        private void textBox9_SpeedOfTransition(object sender, EventArgs e)
        {
            TextBlock(ref _speedOfTransition, textBox9);
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

        private void button2_Example(object sender, EventArgs e)
        {
            ExampleImage exampleImage = new ExampleImage();
            exampleImage.Show();
            exampleImage.ChangeBackgroundPicture(1);
        }
    }
}
