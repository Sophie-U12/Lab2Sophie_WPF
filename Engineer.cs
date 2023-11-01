using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Sophie_WPF
{
    public class Engineer : Employee
    {
		private int numberOfProjects;

		public int NumberOfProjects
		{
			get { return numberOfProjects; }
			set { numberOfProjects = value; }
		}

		public Engineer() : base()
		{
			NumberOfProjects = 0;
		}

		public Engineer(string name, double pCoefficient, int numberOfProjects) : base(name, pCoefficient)
		{
			NumberOfProjects = numberOfProjects;
		}

		public override double GetIncome(double kCoefficient)
		{
			return base.GetIncome(kCoefficient) * (numberOfProjects / 10d);
		}
	}
}
