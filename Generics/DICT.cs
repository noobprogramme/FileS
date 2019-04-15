using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class DICT
    {
        static void Main()
            //sdfsf
        {
            Dictionary<int, string> datas = new Dictionary<int, string>()
                                            {
                                                {1,"One"},
                                                {2, "Two"},
                                                {3,"Three"}
                                            };

            for (int i = 0; i < datas.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", datas.Keys.ElementAt(i), datas[datas.Keys.ElementAt(i)]);
            }
            for (int i = 0; i < datas.Count; i++)//cannot get values 
            {
                Console.WriteLine(datas.Keys +" "+ datas.Values);
            }

            foreach (var i in datas)
            {
                Console.WriteLine(i.Key + "  " + i.Value);
            }
            Console.ReadLine();

        }
    }
}
