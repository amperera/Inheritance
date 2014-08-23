using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Employee
    {
        protected int EmpNumber;
        protected string Name;
        protected string Address;
        protected int MobileNumber;
        protected int BasicSalery;


    }

    public class MonthlyBasis : Employee
    {

        private int OThours;
        private double NetSalary;

        public MonthlyBasis(int basic, int Ot)
        {

            this.BasicSalery = basic;
            this.OThours = Ot;
        }

        public double CalculateMonthlySlary()
        {
            int OtAmount = 30;
            int TotalOTAmount = OThours * OtAmount;

            NetSalary = BasicSalery + TotalOTAmount;

            return NetSalary;


        }



    }

    [TestFixture]
    public class TestClass
    {
        private MonthlyBasis monthly;


        public TestClass()
        {
            monthly = new MonthlyBasis(1500, 30);
        }

        [Test]
        public void TestMonthly()
        {
            var net = monthly.CalculateMonthlySlary();

            Assert.AreEqual(2400, net);


        }

    }
}
