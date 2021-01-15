using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UrtheCast
{
    public class ListManipulation
    {
        public static List<String> Merge(List<String> original, List<String> add, List<String> remove)
        {
            //Concat Original and add
            var list = original.Concat(add);

            //Remove from List
            foreach (String t in remove)
            {
                list = list.Where(item => item != t);
            }

            //Sort order
            return list.OrderByDescending(item => item?.Length)
                .ThenByDescending(item => item)
                .Distinct()
                .ToList();
        }
    }
}
