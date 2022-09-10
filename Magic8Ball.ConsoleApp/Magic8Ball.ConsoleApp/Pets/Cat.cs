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
            return $"{base.GetInformation()} I talk like {sound}";
        }

        public override string GetMorningRoutine()
        {
            throw new NotImplementedException();
        }
    }
}
