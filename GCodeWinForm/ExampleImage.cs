using System;
using System.Drawing;
using System.Windows.Forms;

namespace GCodeWinForm
{
    public partial class ExampleImage : Form
    {
        public ExampleImage()
        {
            InitializeComponent();
        }

        public void ChangeBackgroundPicture(int value)
        {
            if (value == 0)
                pictureBox1.BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image\\simpleExample.png"));
            else
                pictureBox1.BackgroundImage = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image\\midleExample.png"));
        }
    }
}
