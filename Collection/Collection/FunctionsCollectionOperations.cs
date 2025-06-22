using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class FunctionsCollectionOperations : ICollectionOperations
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

        public void DictionaryOperations(Dictionary<string, int> dictionary)
        {
            if (dictionary.ContainsKey("scuba") && dictionary["scuba"] == 6)
            {
                dictionary.Add("dive", 6);
            }
        }

        public void StackOperations(Stack<DateTime> stack)
        {
            throw new NotImplementedException();
        }
    }
}
