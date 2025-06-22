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
            if (list != null)
            {
                if (list.Count() > 0)
                {
                    if (list.Count % 2 == 0)
                    {
                        list.RemoveAt(list.Count / 2 - 1);
                    }
                    else
                    {
                        list.RemoveAt(list.Count / 2);
                    }

                    if (list.Contains("mama"))
                    {
                        list.Add("6");
                    }

                    if (list.IndexOf("course59") != -1 && list.IndexOf("course59") % 2 != 0)
                    {
                        list.Reverse();
                    }

                    if (list.Distinct().Count() == 3 && list.Count >= 2)
                    {
                        list.InsertRange(2, new List<string> { "2", "3", "4" });
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(list));
            }
        }

        public void DictionaryOperations(Dictionary<string, int> dictionary)
        {
            if (dictionary != null)
            {
                if (dictionary.ContainsKey("scuba") && dictionary["scuba"] == 6 && !dictionary.ContainsKey("dive"))
                {
                    dictionary.Add("dive", 6);
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(dictionary));
            }
            
        }

        public void StackOperations(Stack<DateTime> stack)
        {
        }
    }
}
