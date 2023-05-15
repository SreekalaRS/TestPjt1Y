
////Console.WriteLine("Enter emp no:");
////int empNo = Convert.ToInt32(Console.ReadLine());

////Console.WriteLine("Enter emp name:");
////string empName=Console.ReadLine();

////Console.WriteLine("Employee Details:" + empNo +"," + empName);

////4 steps
//int[] values=new int[5]; //declaration   //new means memory allocation
//int[] result= { 1,2,3,4}; //init
//int[] result2= new int[] { 1,2,3,4,5};//memory allocation at run time only

//for (int i = 0; i <values.Length; i++)
//{
//    Console.Write("Enter value:");
//    values[i] =Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Values");
//for (int i = 0; i < values.Length; i++)
//{
//    Console.WriteLine(values[i]);
//}

//for (int i = 0; i < values.Length; i++)
//{
//    Console.WriteLine(values[i]);
//}

using EmployeeConsoleApp;

Employee empobj=new Employee();//obj creation
empobj.CreateEmployee();//function calling
empobj.ReadEmployee();

Network ntobj = new Network();//obj creation
ntobj.ReadNetwork();
