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
            return $"Morning routine of Robot from brand {Name}: " +
                "\n \n " +
                "1. Check charge. " +
                "If charge is below 50, go to charger and recharge." +
                $" Currently my charge is {Charge}." +
                $"\n" +
                $"2. Clean the living room." +
                $"\n" +
                $"3. Clean the bed room." +
                $"\n" +
                $"4. Clean the bathroom." +
                $"\n" +
                $"5. Clean the Kitchen." +
                $"\n" +
                $"6. Return to my home.";
        }
    }
}
