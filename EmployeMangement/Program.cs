using System;
using System.Collections.Generic;

namespace EmployeMangement
{
    class Employee
    {
        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        /// <param name="EmployeeId">Id of Employee</param>
        /// <param name="EmployeeName">Name of Employee</param>
        /// <param name="OrganizationName">Name of organization</param>
        /// <param name="Designation">Designation of Employee</param>
        /// <param name="JoiningYear">Employee Joining year</param>
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string OrganizationName { get; set; }
        public string Designation { get; set; }
        public int JoiningYear { get; set; }
        #endregion

        #region Constructor
        public Employee(int EmployeeId, string EmployeeName, string OrganizationName, string Designation, int JoiningYear)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.OrganizationName = OrganizationName;
            this.Designation = Designation;
            this.JoiningYear = JoiningYear;
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            ///<summary>
            ///list of Employee
            ///</summary>
            List<Employee> employeeData = new List<Employee>();
            #region do-while loop
            do
            {
                Console.WriteLine("==================Employee Data========================");
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("[1]. Enter Employee Data \n[2]. View Employee Data \n[3]. Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        
                        Console.WriteLine("Enter Number of Records You want to enter");
                        int numberOfRecord = Convert.ToInt32(Console.ReadLine());
                        for (int i =0; i <numberOfRecord; i++ )
                        {
                            Console.WriteLine("Enter Employee Name: ");
                            string employeeName = Console.ReadLine();
                            Console.WriteLine("Enter Organization Name: ");
                            string employeeOrganizationName = Console.ReadLine(); ;
                            Console.WriteLine("Enter Designation: ");
                            string employeeDesignation = Console.ReadLine(); ;
                            Console.WriteLine("Enter Joining Year: ");
                            int employeeJoiningYear = Convert.ToInt32(Console.ReadLine());
                            int employeeID = 1000 + i;
                            employeeData.Add(new Employee(employeeID, employeeName, employeeOrganizationName, employeeDesignation, employeeJoiningYear));
                        }
                        break;

                    case 2:
                        foreach(var employee in employeeData)
                        {
                            Console.WriteLine($"Employee Id: {employee.EmployeeId} \nEmployee Name: {employee.EmployeeName} \nOrganization = {employee.OrganizationName} \nEmployee Designation : {employee.Designation} \nTotal Experience: {2021 - employee.JoiningYear}");
                        }
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("==================Employee Data========================");
                        Console.WriteLine("Enter your Choice");
                        Console.WriteLine("[1]. Enter Employee Data \n[2]. View Employee Data \n[3]. Exit");
                        break;
                }
            }
            while (choice != 3);
            #endregion end of loop
        }
    }
}
