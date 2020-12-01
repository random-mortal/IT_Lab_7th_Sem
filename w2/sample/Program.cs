using System;

namespace sample
{

    class College
    {
        string collegeName, principalName;

        public string CollegeName
        {
            get
            {
                return collegeName;
            }

            set
            {
                collegeName = value;
            }
        }

        public string PrincipalName
        {
            get
            {
                return principalName;
            }
            set
            {
                principalName = value;
            }
        }
    }

        class Department : College
        {
            string deptName, hodName;

            public string DeptName
            {
                get
                {
                    return deptName;
                }
                set
                {
                    deptName = value;
                }
            }

            public string HodName
            {
                get
                {
                    return hodName;
                }
                set
                {
                    hodName = value;
                }
            }


        }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Department deptObj = new Department();

            Console.WriteLine("Please enter the names of the college, principal, department and hod.");

            deptObj.CollegeName = Console.ReadLine();
            deptObj.PrincipalName = Console.ReadLine();

            deptObj.DeptName = Console.ReadLine();
            deptObj.HodName = Console.ReadLine();

            Console.WriteLine("College name: {0}", deptObj.CollegeName);
            Console.WriteLine("Principal name: {0}", deptObj.PrincipalName);
            Console.WriteLine("Department name: {0}", deptObj.DeptName);
            Console.WriteLine("HOD name: {0}", deptObj.HodName);
        }
    }
}
