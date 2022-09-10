using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball.ConsoleApp
{
    internal class Pet
    {
        public Pet()
        {

        }
        public Pet(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public virtual string GetInformation()
        {
            return $"My name is: {Name}!!";
        }
    }
}
