using System;
using System.Collections.Generic;
using System.Linq;


namespace Recursive1
{
    class Class1
    {
        static void Main(string[] args)
       
        
        {

            List<int> num = new List<int>() { 1, 2, 3, 4 };

            List<int> result = filter_greater_than(num, 3);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }


            List<int> filter_greater_than(List<int> lst, int n)
            {
                if (lst.Count == 0)
                {
                    return lst;
                }
                else
                {
                    if (lst[0] > n)
                    {
                        return lst.Where(x => x == lst[0]).ToList().Concat(filter_greater_than(lst.GetRange(1, lst.Count - 1), n)).ToList();
                    }
                    else
                    {
                        return filter_greater_than(lst.GetRange(1, lst.Count - 1), n);
                    }

                }
            }
        }
    }
}

   