using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjClass_05Jarvis
{
    class Jarvis
    {
        public long Energy { get; set; }
        public Head Head { get; set; }
        public Torso Torso { get; set; }
        public List<Arm> Arm { get; set; }
        public List<Leg> Leg { get; set; }

        public void AddHead(Head headInput)
        {
            if (headInput.Energy < Head.Energy)
            {
                Head = headInput;
            }
        }
        public void AddTorso(Torso torsoInput)
        {
            if (torsoInput.Energy < Torso.Energy)
            {
                Torso = torsoInput;
            }
        }
        public void AddArm(Arm arm)
        {
            if (Arm == null)
            {
                Arm = new List<Arm>();
            }
            if (Arm.Count < 2)
            {
                Arm.Add(arm);
            }
            else
            {
                for (int i = 0; i < this.Arm.Count; i++)
                {
                    if (Arm[i].Energy > arm.Energy)
                    {
                        Arm.RemoveAt(i);
                        Arm.Add(arm);
                    }
                }
            }
        }

        public void AddLeg(Leg leg)
        {
            if (Leg == null)
            {
                Leg = new List<Leg>();
            }
            if (Leg.Count < 2)
            {
                Leg.Add(leg);
            }
            else
            {
                for (int i = 0; i < this.Leg.Count; i++)
                {
                    if (Leg[i].Energy > leg.Energy)
                    {
                        Leg.RemoveAt(i);
                        Leg.Add(leg);
                    }
                }
            }
        }
        public override string ToString()
        {
            if (Head  == null || Torso == null || Arm.Count< 2 || Leg.Count < 2)
            {
                return "Weneed more parts!";
            }
            long totalEnergy = 0L;
            totalEnergy += Head.Energy;
            totalEnergy += Torso.Energy;
            totalEnergy += Arm.Select(a => a.Energy).Sum();
            totalEnergy += Leg.Select(a => a.Energy).Sum();
            if (totalEnergy > Energy)
            {
                return "";
            }
            return base.ToString();
        }
    }
}
