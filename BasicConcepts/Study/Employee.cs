using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class Employee
    {

        private static int count = 0;

        static Employee()
        {
            count = 100;
        }

        public static void info()
        {
            Console.WriteLine($"Number of employee is {count}.");
        }

        public Employee(string employeeId) // field connected to the lifecycle of object
        {
            count++;
            this.employeeId = employeeId;
        }

        public Employee(string employeeId, string firstName, string lastName)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private string employeeId;
        private string firstName;
        private string lastName;

        public string EmployeeId
        {
            get
            {
                return employeeId;
            }
        }

        //public string Name => $"My name is {firstName} {lastName}.";
        public string Name
        {
            get => $"My name is {firstName}.";
            set => firstName = value;
        }

        private void m1(){ }
        protected void m2() { }
        internal void m3() { }
        protected internal void m4() { }

        public void t() { }
    }
}
