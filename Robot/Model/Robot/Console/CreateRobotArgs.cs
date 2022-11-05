using CommandLine;

namespace ET
{
    public class CreateRobotArgs
    {
        [Option("Zone", Required = false, Default = 1)]
        public int Zone { get; set; }

        [Option("Num", Required = false, Default = 1)]
        public int Num { get; set; }

        [Option("RobotId", Required = false, Default = 0)]
        public int RobotId { get; set; }

    }
}