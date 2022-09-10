using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball.ConsoleApp.Pets
{
    internal class Cat : Pet
    {
        string sound= "Meow";
        public Cat(string name) : base(name)
        {
            
        }
        public override string GetInformation()
        {
            return $"{base.GetInformation()} I talk like {sound}!";
        }

        public override string GetMorningRoutine()
        {
            return "In the morning when my human servants wake up, I yawn and go back to sleep again. " +
                "\nWhy are human so loud???" +
                "\nI wake up at noon and poop. My servants will clean it for me." +
                "\nThen I ask for food from my human roommates.";
        }
    }
}
