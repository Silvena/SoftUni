using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjClass_05Jarvis
{
    class Arm
    {
        public int Energy { get; set; }
        public int ArmReachDistance { get; set; }
        public int CountFingers { get; set; }
        public override string ToString()
        {
            string result = string.Empty;
            result += "#Arm:\r\n";
            result += "###Energy consumption: " + Energy + "\r\n";
            result += string.Format($"###Reach: {ArmReachDistance}\r\n");
            result += string.Format($"###Fingers: {CountFingers}\r\n");
            return result;
        }
    }
}
