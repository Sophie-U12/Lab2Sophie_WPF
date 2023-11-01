using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Sophie_WPF
{
    public class Employee
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private double pCoefficient;

		public double PCoefficient
		{
			get { return pCoefficient; }
			set { pCoefficient = value; }
		}

		public Employee()
		{
			name = "";
			pCoefficient = 0;
		}

		public Employee(string name, double pCoefficient)
		{
			Name = name;
			PCoefficient = pCoefficient;
		}

		public virtual double GetIncome(double kCoefficient)
		{
			return kCoefficient * pCoefficient;
		}
	}
}
