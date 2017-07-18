using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjClass_05Jarvis
{
    class Torso
    {
        public int Energy { get; set; }
        public double ProcessorSize { get; set; }
        public string HousingMaterial { get; set; }
        public override string ToString()
        {
            string result = string.Empty;
            result += "#Torso:\r\n";
            result += "###Energy consumption: " + Energy + "\r\n";
            result += string.Format($"###Processor size: {ProcessorSize}\r\n");
            result += string.Format($"###Corpus material: {HousingMaterial}\r\n");
            return result;
        }
    }
}
