using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Lists
    {
        public List<Names> names = new List<Names>();
        public void AddNamesToList(Names name)
        {
            names.Add(name);
        }


    }
}
