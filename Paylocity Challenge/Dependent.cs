using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paylocity_Challenge
{
    public class Dependent
    {
        private const int basecost = 500;
        public string name = "";
        public int AnnualCost { get; private set; }
        public Dependent(string name)
        {
            this.name = name;
            if (name.StartsWith("A"))
            {
                AnnualCost = (int)(.9 * basecost);
            }
            else
                AnnualCost = basecost;
        }
    }
}
