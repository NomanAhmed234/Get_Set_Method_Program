using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6q1
{
    internal class getSet
    {
        public string name;
        private string pass;
        public string getting()
        {
            return pass;
        }
        public void setting(string _pass)
        {
            pass = _pass;
        }
    }
}
