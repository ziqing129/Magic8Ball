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
        int BonesFound { get; set; }
        public Dog(string name) : base(name)
        {
            BarkedToday = 6;
            BonesFound = 3;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()} I barked {BarkedToday} times today!!";
        }


        public override string GetMorningRoutine()
        {
            return $"Morning routine of Dog {Name}: " +
                "\n \n " +
                "1. Wake up slowly. " +
                $"\n" +
                $"2. Walk to kitchen." + 
                $"\n" +
                $"3. If owner put food in my bowl, eat it." + 
                $"\n" +
                $"4. Bark at neighbour dogs. Today, i barked {BarkedToday} times already!" +
                $"\n" +
                $"5. Go out and dig up some soil to find bones. Today i already found {BonesFound} bones! I am really good, right?" +
                $"\n" +
                $"6. Return to inside and bring some soil with me, so robot has work!";
        }
    }
}
