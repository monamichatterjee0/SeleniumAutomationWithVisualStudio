using System;
namespace AutomationWithCSharp.AllPractice
{
    public struct StructPractice
    {
        int sal, employeeID;
        string name, dept;

       public StructPractice(int s, int empID,string name, string dept)
        {
            this.sal = s;
            this.employeeID = empID;
            this.name = name;
            this.dept = dept;
        }

        public void insertEmployeeDatabase(int sal,int employeeID, string name, string dept)
        {
            Console.Write("Name: {0} Salary: {1} EmployeeID: {2} department: {3}", name, sal, employeeID, dept);
        }
    }

    
}
