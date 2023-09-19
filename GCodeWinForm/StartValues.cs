using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCodeWinForm
{
    internal class StartValues
    {
        public StartValues(float speed, float length, float depth, float step)
        {
            Speed = speed;
            Length = length;
            Depth = depth;
            Step = step;
        }
        public float Speed { get; private set; }
        public float Length { get; private set; }
        public float Depth { get; private set; }
        public float Step { get; private set; }
    }
}
