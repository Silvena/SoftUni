using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodMore_16InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = string.Empty;

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                if (opCode == "END")
                {
                    continue;
                }
                if (codeArgs[0] == "INC")
                {
                    int operandOne = int.Parse(codeArgs[1]);
                    result = ++operandOne;
                }

                if (codeArgs[0] == "DEC")
                {
                    int operandOneDec = int.Parse(codeArgs[1]);
                    result = --operandOneDec;
                }
                if (codeArgs[0] == "ADD")
                {
                    int operandOneAdd = int.Parse(codeArgs[1]);
                    int operandTwoAdd = int.Parse(codeArgs[2]);
                    result = operandOneAdd + operandTwoAdd;
                }
                if (codeArgs[0] == "MLA")
                {
                    int operandOneMla = int.Parse(codeArgs[1]);
                    int operandTwoMla = int.Parse(codeArgs[2]);
                    result = (long)(operandOneMla * operandTwoMla);
                }
              
                Console.WriteLine(result);
             } 
        }
    }
}
