using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computers.Model
{
    public class Computer
    {
        public string IP { get; }
        public List<Tag> Tags { get; }

        public Computer(string iP, List<Tag> tags)
        {
            IP = iP;
            Tags = tags;
        }
    }
}
