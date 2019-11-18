using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paylocity_Challenge
{
    public class Employee
    {
        private const int numpaychecks = 26;
        private const int paycheckamount = 2000;
        private const int benefitcost = 1000;
        private const int basecost = (numpaychecks*paycheckamount)+benefitcost;
        public string name = "";
        public List<Dependent> dependents = new List<Dependent> { };
        public int AnnualCost { get; private set; }
        public Employee(string name)
        {
            this.name = name;
            if (name.StartsWith("A"))
            {
                AnnualCost = (int)(.9 * basecost);
            }
            else
            {
                AnnualCost = basecost;
            }
        }
        public void AddDependent(string name)
        {
            Dependent d = new Dependent(name);
            AnnualCost += d.AnnualCost;
            dependents.Add(d);
        }
        public override string ToString()
        {
            return "Annual Cost: $" + AnnualCost + "\t Number of Dependents: "+dependents.Count;
        }
    }
}
