using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    internal class Network
    {
        public void ReadNetwork()
        {
            FileStream fsObj = new FileStream("networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fsObj);

            Console.WriteLine("Id\tSource\tDestination\tDate\tStatus\tNetwork");

            string line = reader.ReadLine();
            while (line != null)
            {

                string[] values = line.Split(':');
                Console.Write(values[1] + "\t");
                line = reader.ReadLine();
                if (line=="")
                {
                    Console.WriteLine("");
                    line = reader.ReadLine();
                }


                //Console.WriteLine(line);
                //line = reader.ReadLine();
            }
            fsObj.Close();
        }

    }
}
