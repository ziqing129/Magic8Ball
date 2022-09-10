using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball.ConsoleApp.Pets
{
    internal class Robot : Pet 
    {
        public int Charge { get; set; }
        public Robot(string name) : base(name)
        {
            Charge = 100;
        }
        public override string GetInformation()
        {
            return $"{base.GetInformation()} + My Charge is {Charge}";
        }

        public override string GetMorningRoutine()
        {
            throw new NotImplementedException();
        }
    }
}
