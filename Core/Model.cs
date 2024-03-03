using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ArrayFilter
    {
        public static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            
            List<int> resultList = new List<int>();

           
            foreach (int num in originalArray)
            {
                
                if (!filterArray.Contains(num))
                {
                   
                    resultList.Add(num);
                }
            }

            return resultList.ToArray();
        }
    }
}