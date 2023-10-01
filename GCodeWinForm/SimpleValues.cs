namespace GCodeWinForm
{
    internal class SimpleValues
    {
        public SimpleValues(float speed, float length, float depth, float step)
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
