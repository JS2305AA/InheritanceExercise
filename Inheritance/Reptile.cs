using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Reptile : Animal 
    {
        public string environment;
        public string defense;

        public bool HasBackBone { get; }
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set }
        public string Environment { get; set; }
        public string Defense { get; set; }

    public Reptile() 
    {
    } public Reptile( string name, int age, int legs, bool hasBackBone, bool isColdBlooded, bool hasScales)
    {
        Name = name;
        Age = age;
        Legs = legs;
        HasBackBone = hasBackBone;
        IsColdBlooded = isColdBlooded;
        HasScales = hasScales;
        Environment = environment;
        Defense = defense;
    }
}
