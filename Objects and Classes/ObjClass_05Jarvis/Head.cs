using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjClass_05Jarvis
{
    class Head
    {
        public int Energy { get; set; }
        public int IQ { get; set; }
        public string SkinMaterial { get; set; }
        public override string ToString()
        {
            string result = string.Empty;
            result += "#Head:\r\n";
            result += "###Energy consumption: " + Energy + "\r\n";
            result += string.Format($"###IQ: {IQ}\r\n");
            result += string.Format($"###Skin matreil: {SkinMaterial}\r\n");
            return result;
        }
    }
}
