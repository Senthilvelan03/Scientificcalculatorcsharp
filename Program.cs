
using System;
using System.Reflection;


namespace Scientificcalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
       
            string res ;
            string path = "C:\\Users\\senthis\\source\\Calculator history.txt";


            Calculator c = new Calculator();
            Console.WriteLine("---------Scientific Calculator---------");
            while (true)
            {
                try
                {
                    Console.WriteLine("Type(add,div,sqrt,cube,sine,log,addlist) for any operations or type (exit) to exit our application");
                    Console.WriteLine("Note : addlist operation allows you to add the series of integers");
                    string operation = Console.ReadLine();
                    if (operation == "exit")
                    {
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                           
                        }
                        break;
                    }
                    if (operation == "addlist")
                    {
                        Console.WriteLine("Enter the number of integers you wish to get the sum:");
                        int n = Convert.ToInt32(Console.ReadLine());

                        List<int> list = new List<int>(n);

                        Console.WriteLine("Enter the list of Integers:");
                        for (int i = 0; i < n; i++)
                        {
                            list.Add(Convert.ToInt32(Console.ReadLine()));
                        }

                        double sum = c.PerformSumList(out res, list);
                        Console.WriteLine("The Resultant sum of the list is {0}", sum);
                    }
                    else
                    {
                        Console.WriteLine("Enter input 1 for operation: ");

                        double a = double.Parse(Console.ReadLine());
                        double b = 0;
                        if (operation != "sqrt" && operation != "cube" && operation != "sine" && operation != "log")
                        {
                            Console.WriteLine("Enter input 2 for operation: ");
                            b = double.Parse(Console.ReadLine());
                        }

                        double result = c.PerformCalculation(out res, operation, a, b);
                        Console.WriteLine("The Result is {0}", result);


                    } 

                        //File handling to store and display the result
                        using (StreamWriter streamWriter = File.AppendText(path))
                        {
                            streamWriter.WriteLine(res);

                        }
                        using (StreamReader streamReader = File.OpenText(path))
                        {
                            string history;
                            while ((history = streamReader.ReadLine()) != null)
                            {
                                Console.WriteLine($"The previously performed operations are {history}");
                            }
                        }
                        Console.WriteLine("Are you a person who is interested to know something new.... then type (yes) otherwise type (no)");
                        string response = Console.ReadLine();
                        if (response == "no")
                        {
                            continue;
                        }
                        else 
                        {
                            Type T = typeof(Calculator);
                            MethodInfo[] methods = T.GetMethods();
                            foreach (MethodInfo method in methods)
                            {
                                Console.WriteLine($"The calculator's functionality is implemented through the method with returntype {method.ReturnType.Name} and functionname {method.Name}");
                            }
                        }
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}





