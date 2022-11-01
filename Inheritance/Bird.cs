using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird
    {
        public int Wings { get; set; }
        public string Type { get; set; }
        public bool IsWarmBlooded { get; set; }
        public bool HasBackbone { get; set; }
        public bool HasFeathers { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Legs { get; set; }


        public Bird()
        {

        }

        public Bird(string name, int age, int legs, bool hasBackbone, bool isWarmBlooded, bool hasFeathers, int wings)
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasBackbone = hasBackbone;
            HasFeathers = hasFeathers;
            Wings = wings;
            Type = Type;
        }

    }
}
