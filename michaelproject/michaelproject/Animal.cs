using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace michaelproject
{
    internal class Animal
    {
        public string _name;
        public int _eye;
        public bool _true;

        public Animal()
        {
        }

        public Animal(string name, int eye, bool @true)
        {
            _name = name;
            _eye = eye;
            _true = @true;
        }
    }
}
