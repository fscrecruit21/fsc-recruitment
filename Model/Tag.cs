using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computers.Model
{
    public class Tag
    {
        public string Name { get; }
        public string Color { get; }

        public Tag(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
