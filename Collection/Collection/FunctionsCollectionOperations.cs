using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class FunctionsCollectionOperations
    {
        public void ListOperations(List<string> list)
        {
            if (list.Count() % 2 == 0)
            {
                list.RemoveAt(list.Count() / 2 - 1);
            }
            else
            {
                list.RemoveAt(list.Count() / 2);
            }

            if (list.Contains("mama"))
            {
                list.Add("6");
            }

            if (list.IndexOf("course59") % 2 != 0)
            {
                list.Reverse();
            }

            if (list.Distinct().Count() == 3)
            {
                list.InsertRange(2, new List<string> {"2","3","4"});
            }
        }
    }
}
