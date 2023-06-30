using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolution
{
    internal struct IntToString
    {
        public IntToString() { }

        public void Method(int[] arr1)
        {

            string[] arr2 = new string[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i].ToString();
                Console.Write(arr2[i]+ " , ");
            }
        }
    }
}
