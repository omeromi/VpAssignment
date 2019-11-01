using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
                {
                int a;
                Student obj = new Student();
                string path = args[0];
                string path1 = args[1];

                obj.getPath(path, path1);
                //string path = @"C:\Users\Omii\Desktop\Assignment#1";
                Console.WriteLine("1. Create Student Profile");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3.Delete Student Reord");
                Console.WriteLine("4. List Top 3 of class");
                Console.WriteLine("5. Mark Attendace");
                Console.WriteLine("6. View Attendance");
                Console.WriteLine("7.Exit");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            obj.profile();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("1. Search By Id\n2.Search By Name\n3.Display List");
                            int choice2 = Convert.ToInt32(Console.ReadLine());
                            if (choice2 == 1)
                            {
                                Console.WriteLine("Enter Student Id to searh :");
                                int id = Convert.ToInt32(Console.ReadLine());
                                obj.searchById(id);
                            }
                            else if (choice2 == 2)
                            {
                                Console.WriteLine("Enter Student Name to searh :");
                                string name = Console.ReadLine();
                                obj.searchByName(name);
                            }
                            else if (choice2 == 3)
                            {
                                obj.SearchAll();
                            }
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Enter id to delete \n");
                            int id = Convert.ToInt32(Console.ReadLine());
                            obj.delete(id);
                            break;
                        }
                    case 4:
                        {
                            obj.top_3();
                            break;
                        }
                    case 5:
                        {
                            obj.markAttend();
                            break;
                        }
                    case 6:
                        {
                            obj.viewAttend();
                            break;
                        }
                    case 7:
                        {
                            System.Environment.Exit(1);
                            break;
                        }
                }
            }
        }
    }
}



