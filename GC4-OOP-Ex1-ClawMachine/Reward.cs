using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GC4_OOP_Ex1_ClawMachine
{
    public class Reward
    {
        public string Name {  get; set; }
        public decimal Value { get; set; }
        public Reward(string name, decimal value)
        {
            Name = name;
            Value = value;
        }

    }

}
