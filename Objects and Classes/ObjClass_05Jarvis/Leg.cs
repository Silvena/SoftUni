using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjClass_05Jarvis
{
    class Leg
    {
        public int Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public override string ToString()
        {
            string result = string.Empty;
            result += "#Leg:\r\n";
            result += "###Energy consumption: " + Energy + "\r\n";
            result += string.Format($"###Strength: {Strength}\r\n");
            result += string.Format($"###Speed: {Speed}\r\n");
            return result;
        }
    }
}
