using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class employee
    {
        public string name;
        public string pos;
        public int id;

    }
    class Program
    {
    //    public T ii { get; set; }
    //    public V ss { get; set; }
         
    //    public  void operations(T Ii, V Ss) {
    //        this.ii = Ii;
    //        this.ss = Ss;

    //    }


        static void Main(string[] args)
        {
            List<employee> emp = new List<employee>();
            employee c1 = new employee { id = 123, name = "hemanth", pos = "software" };
            employee c2 = new employee { id = 231, name = "kumar", pos = "data " };
            emp.Add(c1);
            emp.Add(c2);
            foreach(employee obj in emp)
            {
                Console.WriteLine(obj.pos+ "   "+obj.name);
                
            }
            Console.ReadLine();
        }
    }
}
