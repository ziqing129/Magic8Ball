using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball.ConsoleApp.Pets
{
    internal class Dog : Pet
    {
        int BarkedToday { get; set; }
        public Dog(string name) : base(name)
        {
            BarkedToday = 6;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()} I barked {BarkedToday} times today!!";
        }
    }
}
