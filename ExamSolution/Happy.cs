using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolution
{
    internal class Happy
    {
        public int y;
        public Happy() { }
        public Happy(int y) 
        {
            this.y = y;
        }
        public void Plural(int y)
        {
            if(y % 2 == 0) 
            {
                Console.WriteLine("This member is plural");
            }
        }
    }
}
