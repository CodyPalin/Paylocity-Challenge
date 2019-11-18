using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paylocity_Challenge
{
    public partial class Form1 : Form
    {
        public class ListItem
        {
            public string name;
            public Employee employee;
            public override string ToString()
            {
                return name;
            }
        }
        private int totalcost = 0;
        private readonly List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        public void AddEmployee(string name)
        {
            Employee e = new Employee(name);
            employees.Add(e);
            CalculateTotalCost();
            EmployeeList.Items.Add(new ListItem { name = e.name, employee = e });
            NumEmployees.Text = "" + employees.Count;

        }
        public void CalculateTotalCost()
        {
            int cost = 0;
            foreach(Employee e in employees)
            {
                cost += e.AnnualCost;
            }
            totalcost = cost;
            YearlyCost.Text = "$" + totalcost;
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {

            NameForm nameform = new NameForm("Employee");
            if (nameform.ShowDialog(this) == DialogResult.OK)
            {
                AddEmployee(nameform.PersonName);
                if(EmployeeList.SelectedIndex <0)
                    EmployeeList.SelectedIndex = 0;
                if(button2.Enabled == false)
                {
                    button2.Enabled = true;
                }
            }
            nameform.Dispose();
        }

        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee employee = (EmployeeList.SelectedItem as ListItem).employee;
            EmployeeInfo.Text = employee.ToString();
        }

        private void AddDependent_Click(object sender, EventArgs e)
        {
            Employee employee = (EmployeeList.SelectedItem as ListItem).employee;
            NameForm nameform = new NameForm("Dependent");
            if (nameform.ShowDialog(this) == DialogResult.OK)
            {
                employee.AddDependent(nameform.PersonName);
                CalculateTotalCost();
                EmployeeInfo.Text = employee.ToString();
            }
            nameform.Dispose();
        }
    }
}
