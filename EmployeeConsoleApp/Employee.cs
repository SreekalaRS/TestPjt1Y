using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//Parent, child, subchild
using System.IO; //File handling

namespace EmployeeConsoleApp
{
    public class Employee
    {
        public void Data()
        {
            Console.WriteLine("");
            Console.WriteLine(100);
        }

        public void Data(int i)
        {
           
        }

        public void CreateEmployee()
        {
            FileStream fsObj = new FileStream("employee.txt", FileMode.Create, FileAccess.Write);
            //Console.WriteLine(fsObj.Name + " " + fsObj.Length);
            StreamWriter writer=new StreamWriter(fsObj);
            writer.WriteLine("Employee id: 11");
            writer.WriteLine("Employee name: sreekala");
            writer.WriteLine("Employee salary: 1000000");

            Console.WriteLine("Write operation completed");
            writer.Close();
            fsObj.Close();
        }

        public void ReadEmployee()
        {
            FileStream fsObj = new FileStream("employee.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fsObj);

            string line=reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            fsObj.Close();
        }

    }
}
