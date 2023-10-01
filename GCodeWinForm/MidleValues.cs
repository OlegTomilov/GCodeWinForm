namespace GCodeWinForm
{
    internal class MidleValues
    {
        public MidleValues(float depth, float step,
                           float speedOfDepth, float speedOfTransition, float mainDistance,
                           float midleDistance, float lastDistance, float mainSpeed,
                           float midleSpeed, float lastSpeed, float countOfDepth)
        {
            Depth = depth;
            Step = step;
            SpeedOfDepth = speedOfDepth;
            SpeedOfTransition = speedOfTransition;
            MainDistance = mainDistance;
            MidleDistance = midleDistance;
            LastDistance = lastDistance;
            MainSpeed = mainSpeed;
            MidleSpeed = midleSpeed;
            LastSpeed = lastSpeed;
            CountOfDepth = countOfDepth;
        }

        public float Depth { get; private set; }
        public float Step { get; private set; }
        public float SpeedOfDepth { get; private set; }
        public float SpeedOfTransition { get; private set; }
        public float MainDistance { get; private set; }
        public float MidleDistance { get; private set; }
        public float LastDistance { get; private set; }
        public float MainSpeed { get; private set; }
        public float MidleSpeed { get; private set; }
        public float LastSpeed { get; private set; }
        public float CountOfDepth { get; private set; }
    }
}
