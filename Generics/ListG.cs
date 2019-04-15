using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ListG
    {
        public bool an<A>(A a,A b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main()
        {
            ListG ali = new ListG();
            bool val = ali.an<int>(1, 2);
            List<int> li = new List<int>();
            li.Add(123);
            li.Add(324);
            
        }
        
        
        
    }
}
