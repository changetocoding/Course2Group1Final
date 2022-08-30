using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace michaelwork
{
    internal class Animal
    {
        public string _name{ get; set; }
        private int _eye;
        public bool _regurgitation { get; set; }
        public int _eyeproperties
        {
            get { return _eye; }
            set
            {
                if (_regurgitation=true && value > 2)
                {
                    _eye = 2;
                }
           
                else if (_regurgitation=false && value >= 8)
                {
                    _eye = 8;
                }
            }
        }
      
       
      

        public Animal()
        {
        }

        public Animal(string name, int eye, bool regurtitation)
        {
            _name = name;
            _eyeproperties = eye;
            _regurgitation = regurtitation;
        }
    }
}
